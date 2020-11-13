motorcars <- read.csv("https://vincentarelbundock.github.io/Rdatasets/csv/datasets/mtcars.csv", stringsAsFactors = FALSE)


cor.test(motorcars$wt, motorcars$mpg,method="pearson") #Correlation by Pearson +значущість

cor.test(motorcars$wt, motorcars$mpg,method="spearman") #Correlation by Spearman +значущість
cor.test(motorcars$wt, motorcars$mpg,method="kendal")#Correlation by Kendall +значущість

plot(motorcars$mpg, motorcars$wt, xlab = 'MPG', ylab = 'WT')

motorcars.cor=cor(mtcars)

mc_data <- motorcars[,2:length(motorcars)]
round(cor(mc_data),2)

plot(motorcars$wt, motorcars$disp)

head(mtcars)

par(mfrow = c(2,2))
plot(motorcars$wt, motorcars$mpg)
plot(motorcars$cyl, motorcars$mpg)
plot(motorcars$disp, motorcars$mpg)
plot(motorcars$hp, motorcars$mpg)

pairs(mtcars[,1:5], panel = panel.smooth)
library("Hmisc")

motorcars.rcorr= rcorr(as.matrix(mtcars))
motorcars.rcorr

motorcars.coeff = motorcars.rcorr$r
motorcars.p = motorcars.rcorr$P

motorcars.coeff
motorcars.p

res <- cor(mtcars)
round(res, 2)

install.packages("corrplot")
library(corrplot)

corrplot(res, type="upper")

# mat : is a matrix of data
# ... : further arguments to pass to the native R cor.test function
cor.mtest <- function(mat, ...) {
  mat <- as.matrix(mat)
  n <- ncol(mat)
  p.mat<- matrix(NA, n, n)
  diag(p.mat) <- 0
  for (i in 1:(n - 1)) {
    for (j in (i + 1):n) {
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

corrplot(res, method = "number")

palette = colorRampPalette(c("green", "white", "red")) (20)
heatmap(x = res, col = palette, symm = TRUE)

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

lattice::splom(mtcars[, 1:5])
