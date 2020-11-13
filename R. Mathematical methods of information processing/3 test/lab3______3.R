motorcars <- read.csv("https://raw.github.com/vincentarelbundock/Rdatasets/master/csv/carData/Rossi.csv", stringsAsFactors = FALSE)
#Інклудю дадасет з машинами

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

cor.test(motorcars$wt, motorcars$mpg,method="pearson") #Correlation by Pearson +значущість

cor.test(motorcars$wt, motorcars$mpg,method="spearman") #Correlation by Spearman +значущість
cor.test(motorcars$wt, motorcars$mpg,method="kendal")#Correlation by Kendall +значущість

plot(motorcars$mpg, motorcars$wt, xlab = 'MPG', ylab = 'WT') #Будую діаграму розсіювання

motorcars.cor=cor(mtcars) #Беру ККП всіх значень зі всіма( для створення матриці)

mc_data <- motorcars[,2:length(motorcars)] #Беру і виключаю назву (Х) із таблиці
round(cor(mc_data),2) #Кореляційня матриця всього із всім

plot(motorcars$wt, motorcars$disp) #Діаграма розсіювання двох інших значень. Просто так

head(mtcars) # Для себе виводжу перші 6 значень із таблиці

par(mfrow = c(2,2)) #Ця штучка дозволяє помістити тут 4 графіки
plot(motorcars$wt, motorcars$mpg) #wt з mpg
plot(motorcars$cyl, motorcars$mpg) #cyl + mpg
plot(motorcars$disp, motorcars$mpg) #disp +mpg
plot(motorcars$hp, motorcars$mpg) #hp+mpg

pairs(mtcars[,1:5], panel = panel.smooth) #будую матричні діаграми розсіювання та проводжу згладжуючу пряму
library("Hmisc") #інклюд бібліотеки

motorcars.rcorr= rcorr(as.matrix(mtcars)) #Квадратна кореляційна матриця Корел. Граф
motorcars.rcorr

plot(motorcars.rcorr, motorcars.rcorr)

motorcars.coeff = motorcars.rcorr$r #витягують значення p або коефіцієнти кореляції з виводу
motorcars.p = motorcars.rcorr$P # витягують значення p або коефіцієнти кореляції з виводу

motorcars.coeff #display
motorcars.p #

res <- cor(mtcars)
round(res, 2) #Ще одна матриця кореляції

install.packages("corrplot") 
library(corrplot) #install package

corrplot(res, type="upper") #Графік кореляції із кружечками

# mat : is a matrix of data
# ... : further arguments to pass to the native R cor.test function
cor.mtest <- function(mat, ...) {
  mat <- as.matrix(mat)
  n <- ncol(mat)
  p.mat<- matrix(NA, n, n)
  diag(p.mat) <- 0
  for (i in 1:(n - 1)) {
    for (j in (i + 1):n) {                           #Метод, який дозволяє закреслити маленькі значення кореляції(нульові)
      tmp <- cor.test(mat[, i], mat[, j], ...)
      p.mat[i, j] <- p.mat[j, i] <- tmp$p.value
    }
  }
  colnames(p.mat) <- rownames(p.mat) <- colnames(mat)
  p.mat
}
# matrix of the p-value of the correlation
p.mat <- cor.mtest(mtcars)
head(p.mat[, 1:5])



corrplot(res, type="upper",order="hclust",
         p.mat=p.mat,sig.level = 0.01)

corrplot(res, method = "number") #Графік кореляції з значеннями

palette = colorRampPalette(c("green", "white", "red")) (20)
heatmap(x = res, col = palette, symm = TRUE)    #Графік кореляції типу heatmap

install.packages("gclus")
library(gclus)

# получим вектор коэффициентов (по модулю)
coeffs <- abs(cor(motorcars[7:11])) 
coeffs

# зададим цвета (автоматическое разбиение по вектору коэффициентов)
colors <- dmat.color(coeffs) 
colors
# отсортируем так, чтобы графики, где связь переменных наибольшая,
# были ближе к диагонали

order <- order.single(coeffs)
order
# строим сам график

# gap - расстояние между графиками в матрице

cpairs(motorcars[7:11], order, panel.colors = colors, gap = .5,
       main = "Correlations Car Specifications" )

library(lattice) #Додаю бібліотеку
library(qgraph)
M <- cor(mtcars) # рахуємо кореляцiї для даних про автомобiлi
qgraph(M) # виводимо верхнiй рисунок
#
grp<-as.factor(c(3,1,1,1,3,1,2,2,3,3,1)) # список номерiв груп
# виводимо нижнiй рисунок:
qgraph(M,layout="groups",groups=grp,minimum=0.5)
lattice::splom(mtcars[, 1:5])  #Теж графік кореляції(інша бібліотека)