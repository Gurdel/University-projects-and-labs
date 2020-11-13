

#The data was extracted from the 1974 Motor Trend US magazine, and comprises fuel consumption and 10 aspects of automobile design and performance for 32 automobiles (1973–74 models).
#[, 1]  mpg  Miles/(US) gallon
#[, 2]  cyl  Number of cylinders
#[, 3]  disp  Displacement (cu.in.)
#[, 4]  hp  Gross horsepower
#[, 5]  drat  Rear axle ratio
#[, 6]  wt  Weight (1000 lbs)
#[, 7]  qsec  1/4 mile time
#[, 8]  vs  Engine (0 = V-shaped, 1 = straight)
#[, 9]  am  Transmission (0 = automatic, 1 = manual)
#[,10]  gear  Number of forward gears
#[,11]  carb  Number of carburetors

m <- read.csv("https://raw.githubusercontent.com/vincentarelbundock/Rdatasets/master/csv/datasets/mtcars.csv", stringsAsFactors = FALSE)
x <- (m[,2:length(m)])

plot(x$mpg~x$wt) #matrichna diagrama rozsiyuvanna
abline(lm(x$mpg~x$wt),col="red")

plot(x$disp~x$wt) #matrichna diagrama rozsiyuvanna
abline(lm(x$disp~x$wt),col="red")

plot(x$hp~x$cyl) #matrichna diagrama rozsiyuvanna
abline(lm(x$hp~x$cyl),col="red")


#rahuemo parametry
lm.x <- lm(formula= x$mpg~x$wt,data=x)
lm.x$coefficients
plot(x$mpg,x$wt) #Р”С–Р°РіСЂР°РјР° СЂРѕР·СЃС–СЋРІР°РЅРЅСЏ
bls1<- lm(x$mpg~x$wt,data=x)$coefficients
bls1
abline(lm(x$mpg~x$wt),col="red")
segments(x$mpg,x$wt,x$mpg,bls1[1]+bls1[2]*x$wt)














#Вивід модельних значень
a0<- lm.x$coefficients[1]
a1<-lm.x$coefficients[2]
xmin<-min(x$mpg)
xmax<-max(x$mpg)
t<-seq(from=xmin,to=xmax,length.out = 100)
y<-a0+a1*t

#Вивід графіка залежності
plot(x$mpg,x$wt)
grid()
lines(t,y,col="red")

summary(lm.x)

#Горизонтальна Регресія
par(mfrow = c(1,2))
als2<- lm(log(deaths)~log(drivers),data=edcT)$coefficients
summary(als2)
1#Діаграма розсіювання
plot(log(edcT$deaths),log(edcT$drivers), 
     xlab="Deaths", ylab="Drivers",sub="(a)")
abline(bls1,col="blue") # bls1 з попереднього скрипту
abline(c(-als2[1]/als2[2],1/als2[2]),col="red")

segments(log(edcT$deaths),log(edcT$drivers),
         + als2[1]+als2[2]*log(edcT$drivers),log(edcT$drivers))

#Ортогональна Регресія

#Тут для пiдрахунку коефiцiєнтiв ортогональної регресiї використана
#функцiя Deming() з бiблiотеки MethComp. Перший її параметр — це регресор
#(горизонтальна координата), а другий — вiдгук (вертикальна координата).
#Звернiть увагу на те, що при вiдображеннi рисунку функцiєю plot() встановлена опцiя asp=1, яка задає однаковий масштаб як по горизонталi, так i
#по вертикалi. Iнакше вiдрiзки, що з’єднують точки даних з їх проекцiями на
#рисунку не виглядали б перпендикулярними до лiнiї регресiї.

library(MethComp)

tls<-Deming(edcT$deaths,edcT$drivers)

x<-edcT$deaths
y<-edcT$drivers
b0<-tls[1]
b1<-tls[2]

# розраховуємо координати проекцiй даних на пряму регресiї:

x0<-(x+b1*y-b0*b1)/(1+b1^2)
y0<-b0+b1*x0

plot(edcT$deaths,edcT$drivers,asp=1,
     xlim=c(155,1000),ylim=c(90,400),sub="(b)")
segments(x,y,x0,y0)
abline(tls[1:2],col="green")

abline(bls1,col="blue")

abline(c(-als2[1]/als2[2],1/als2[2]),col="red")

#Регресiя ваги та зросту актрис: а) “обернена” регресiя b) ортогональна
#регресiя. Лiнiя регресiї: синiм — звичайний МНК, червоним — “обернена”,
#зеленим — ортогональна.

#Квантильна Регресія
par(mfrow = c(1,1))
#install.packages("quantreg")
library("quantreg")
plot(edcT$deaths,edcT$drivers,xlim=c(155,1000),
     xlab="height",ylab="weight")
lmed<-rq(drivers~deaths,tau=0.5,data=edcT)$coefficients
abline(lmed)

lq10<-rq(drivers~deaths,tau=0.1,data=edcT)$coefficients
abline(lq10,col="red")

actr10<-edcT[edcT$deaths<lq10[1]+lq10[2]*edcT$drivers,]
text(edcT$drivers,edcT$deaths,
     labels=actr10$name,pos=4,col="red")

lq90<-rq(drivers~deaths,tau=0.9,data=edcT)$coefficients
abline(lq90,col="blue")

actr90<-edcT[edcT$drivers>lq90[1]+lq90[2]*edcT$deaths,]
text(actr90$drivers,actr90$deaths,
     labels=actr90$name,pos=4,col="blue")

#install.packages("car")
library(car)
scatterplotMatrix(edcT,diagonal="histogram",smoother=F)

model<- lm(edcT$drivers~edcT$deaths+edcT$fuel,data=edcT)
summary(model)
#дiаграма прогноз вiдгук
plot(model$fitted.values,edcT$drivers,
     xlab="Drivers Forecast",ylab="True drivers")
abline(c(0,1),col="red")

#Щоб помiтити такi нелiнiйнi ефекти краще користуватись дiаграмою
#прогноз-залишки:
plot(model$fitted.values,model$residuals,
     xlab="prediction",ylab="residuals") 

abline(0,0,col="red")
#Побудуємо QQ-дiаграму для перевiрки
#нормальностi розподiлу похибок: 

qqnorm(model$residuals)
qqline(model$residuals,col="red")

#8. 
model2 <- lm(drivers~deaths+fuel+I(deaths*fuel)^2, data = edcT)
summary(model2)

#Графічний аналі ззалишків
plot(model2$residuals~model2$fitted.values)
abline(0,0,col="red")
qqnorm(model2$residuals)
qqline(model2$residuals,col="red")
