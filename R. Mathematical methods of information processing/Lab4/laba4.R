install.packages("car")
library(car)

buf <- read.csv("https://raw.githubusercontent.com/vincentarelbundock/Rdatasets/master/csv/MASS/road.csv", stringsAsFactors = FALSE)
d <- (buf[,2:length(buf)])

#1
plot(d$deaths~d$drivers) #matr diagr rozs
abline(lm(d$deaths~d$drivers),col="red")

#2
lm.d <- lm(formula= d$deaths~d$drivers,data=d)
lm.d$coefficients
plot(d$drivers,d$deaths)
b<- lm(d$deaths~d$drivers,data=d)$coefficients
b
abline(lm(d$deaths~d$drivers),col="red")
segments(d$drivers,d$deaths,d$drivers,b[1]+b[2]*d$drivers)

#3
b0<- lm.d$coefficients[1]
b1<-lm.d$coefficients[2]
xmin<-min(d$deaths)
xmax<-max(d$deaths)
x<-seq(from=xmin,to=xmax,length.out = 100)
y<-b0+b1*x
plot(d$deaths,d$drivers)
grid()
lines(y,x,col="red")
summary(lm.d)

scatterplotMatrix(d,diagonal="histogram",smoother=F)
#4
reslm<- lm(d$drivers~d$deaths,data=d)
summary(reslm)
plot(reslm$fitted.values,d$drivers,
     xlab="Drivers Forecast",ylab="True drivers")
abline(c(0,1),col="red")

#5
plot(reslm$fitted.values,reslm$residuals,
     xlab="prediction",ylab="residuals") 
abline(0,0,col="red")

#6
qqnorm(reslm$residuals)
qqline(reslm$residuals,col="red")


#4
reslm<- lm(d$deaths~d$drivers+d$rural,data=d)
summary(reslm)
plot(reslm$fitted.values,d$deaths)
abline(c(0,1),col="red")

#5
plot(reslm$fitted.values,reslm$residuals,
     xlab="prediction",ylab="residuals") 
abline(0,0,col="red")

#6
qqnorm(reslm$residuals)
qqline(reslm$residuals,col="red")
