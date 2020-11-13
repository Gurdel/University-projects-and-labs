install.packages("corrplot") 
install.packages("qgraph")
library(corrplot)
library(qgraph)

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

#matrichni diagramy rozsiyuvanna
pairs(x, panel = panel.smooth) #matrichni diagr rozs i zgladzuyucha pryama
plot(x$mpg,x$wt) #matrichna diagrama rozsiyuvanna
plot(x$disp,x$wt) #matrichna diagrama rozsiyuvanna
plot(x$hp,x$cyl) #matrichna diagrama rozsiyuvanna

M <- cor(x) #matrica korelacii
M
corrplot(M, type="upper") #kor matr kruzechkami
corrplot(M, method = "number") #kor matr ciframi
qgraph(M) #graf

cor.test(x$mpg, x$wt, method="pearson") #kor pirsona
cor.test(x$mpg, x$wt, method="spearman") #kor spirmana
cor.test(x$mpg, x$wt,  method="kendal")#kor kendala

cor.test(x$disp, x$wt, method="pearson") #kor pirsona
cor.test(x$disp, x$wt,  method="spearman") #kor spirmana
cor.test(x$disp, x$wt,  method="kendal")#kor kendala

cor.test(x$hp, x$cyl, method="pearson") #kor pirsona
cor.test(x$hp, x$cyl,  method="spearman") #kor spirmana
cor.test(x$hp, x$cyl,  method="kendal")#kor kendala

cor.test(x$gear, x$carb,  method="pearson") #kor pirsona
cor.test(x$gear, x$carb,  method="spearman") #kor spirmana
cor.test(x$gear, x$carb,  method="kendal")#kor kendala
