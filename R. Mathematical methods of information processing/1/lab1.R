x <- c(8999, 9999, 6399, 6799, 5499, 5999, 7999, 7989, 4999, 9099, 5199, 10499, 10349, 10999, 9999, 18524, 9475, 8899, 20899, 8999, 12349, 6899, 12999, 10599, 10799, 17999, 14849, 8445, 14849, 14259, 10529, 14249, 14249, 6099, 8999, 10529, 8899, 8279, 5299, 5499, 7599, 7699, 5699, 9799, 4699, 5399, 7999, 10799, 8199, 7399, 11499, 11399, 5299, 5599, 5699, 5799, 8099)
mean(x) #vibirkove ser
median(x) #mediana
1/mean(1/x) #ser garmoniine
prod(x)^(1/length(x)) #ser geom
var(x) #dispersiya
sd(x) #standartne vidhilennya
sd(x)/mean(x)*100 #koef variacii
quantile(x) #pyatitockova harakteristica
summary(x) #osnovni harakteristiki
range(x) #min i max
diff(range(x)) #max-min
IQR(x) #interkvartilnii rozmah
boxplot(x, main="Prices of popular washing machines on Rozetka.com.ua", xlab="Price", col="brown", horizontal=TRUE, notch=TRUE)

install.packages("moments")
library(moments)

skewness(x) #koef asimetrii
kurtosis(x) #koef ekscesu
quantile(x,probs=c(0.1,0.9)) #1 ta 9 decili
quantile(x,p=seq(0,1,0.1))
hist(x)