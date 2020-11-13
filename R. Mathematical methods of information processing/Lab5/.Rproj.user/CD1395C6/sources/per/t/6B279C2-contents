install.packages("doBy")
require(doBy)
library(ggplot2)

#New Car Interest rates
# p = rate
# c = city
# 1 = Atlanta; 2 = Chicago; 3 = Houston
x<- read.csv("cars.csv",stringsAsFactors = FALSE)
x$c <- as.factor(x$c)

#1
MeanC <-tapply(x$p,x$c,mean) #seredni znachennya po kozhniy gradacii
stripchart(x$p~x$c,pch = 19,col = c("blue", "red", "black"))
Means <- data.frame( p= as.numeric(tapply(x$p,x$c, mean)),c = rep("Means", 3))
data <- rbind(x,Means)
stripchart(data$p ~ data$c, pch = 19,col = c("blue", "red", "green"))
points(x = Means$p, y = c(4, 4, 4), pch = 19,col = c("blue", "red", "green"))

#2
summary(x)
ggplot(data = x, aes(x = x$c, y = x$p)) + geom_boxplot(aes(fill = x$c))
plot.design(x)
#DA cherez liniynu model lm()
attach(x)
lm.res <-lm(x$p ~ x$c)
summary(lm.res)
anova(lm.res)#norm DA
kruskal.test(x$p,x$c,data=x) #kruskal-wallis DA

#3
contrasts(x$c) #matrica contrastiv
contrasts(x$c)<-contr.sum(n=3) #contrasty sum
contrasts(x$c)
#sumi po stovpchikam = 0, na vidminu vid kontrastiv umov (poperednya matrica)

#vykonuemo DA. interpritacia ocinenyh parametriv modely takoj zminilasya
lm3.res<- lm(x$p~x$c,data=x)
summary(lm3.res)
#(Intercept) - ser znachennya

#contrast helmerta
contrasts(x$c) <- contr.helmert(n = 3)
contrasts(x$c)
#suma po stovpcyah = 0 i suma dobutkiv stovpciv takoj = 0. napr:
mat <- contrasts(x$c)
sum(mat[, 1]*mat[, 2])
#taki contrasty naz ortogonalnimy

#rahuemo parametry novoi liniinoi modeli
lm.res4 <- lm(x$p ~ x$c, data = x)
summary(lm.res4)

#an kontr met tuki
K<-aov(x$p ~ x$c, data=x)
TukeyHSD(K)
plot(TukeyHSD(K), las=1)
