x <- read.csv("shoes.csv")
#замовлення в магазині взуття

install.packages("Hmisc")
library("Hmisc")
install.packages("corrplot") 
library(corrplot)
install.packages("gclus")
library(gclus)
install.packages("lattice")
library(lattice)
install.packages("qgraph")
library(qgraph)

#matrichni diagramy rozsiyuvanna
plot(x$amounce, x$height)
plot(x$amounce, x$weight)
plot(x$amounce, x$time)
plot(x$amounce, x$size)
plot(x$height, x$weight)
plot(x$height, x$size)
plot(x$weight, x$size)
plot(x$time, x$size)

x.cor=cor(x) #Беру ККП всіх значень зі всіма( для створення матриці)
round(cor(x),2) #Кореляційня матриця всього із всім
pairs(x, panel = panel.smooth) #будую матричні діаграми розсіювання та проводжу згладжуючу пряму

x.rcorr= rcorr(as.matrix(x)) #Квадратна кореляційна матриця Корел. Граф
x.rcorr

x.coeff = x.rcorr$r #витягують значення p або коефіцієнти кореляції з виводу
x.p = x.rcorr$P # витягують значення p або коефіцієнти кореляції з виводу

x.coeff #display
x.p #

res <- cor(x)
round(res, 2) #Ще одна матриця кореляції

corrplot(res, type="upper") #Графік кореляції із кружечками

# matrix of the p-value of the correlation
p.mat <- cor.mtest(x)
head(p.mat)

corrplot(res, method = "number") #Графік кореляції з значеннями

heatmap(x = res,symm = TRUE)    #Графік кореляції типу heatmap

# получим вектор коэффициентов (по модулю)
coeffs <- abs(cor(x)) 
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

cpairs(x, order, panel.colors = colors, gap = .5)

lattice::splom(mtcars[, 1:5])  #Теж графік кореляції(інша бібліотека)
M <- cor(x) # рахуємо кореляцiї для даних про автомобiлi
qgraph(M) # виводимо верхнiй рисунок
#
grp<-as.factor(c(3,1,1,1,3,1,2,2,3,3,1)) # список номерiв груп
# виводимо нижнiй рисунок:
qgraph(M,layout="groups",groups=grp,minimum=0.5)

