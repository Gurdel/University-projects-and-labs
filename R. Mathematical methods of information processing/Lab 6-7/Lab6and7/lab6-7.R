install.packages("TTR")
install.packages("forecast")

library("TTR")
library("forecast")

#Similarly, the file http://robjhyndman.com/tsdldata/data/fancy.dat contains monthly sales 
#for a souvenir shop at a beach resort town in Queensland, Australia, for January 1987-December 
#1993 (original data from Wheelwright and Hyndman, 1998)
#ts = time series = chas ryad

#1
s <- scan("http://robjhyndman.com/tsdldata/data/fancy.dat")
sts <- ts(s, frequency=12, start=c(1987,1))
sts
plot(sts, xlab = "Time", ylab = "Sales") 
#kolivannya zbilshuyutsya z chasom. aditivna model ne pidhodit
logsts<-log(sts)
plot(logsts, xlab = "Time", ylab = "Sales") 
#kolivannya odnakovi
is.ts(sts)#perevirka na ts
is.ts(logsts)

#2
#SMA = simple moving average = proste ruhome ser
#n = vikno zgladjuvannya
plot(logsts, xlab = "Time", ylab = "Sales") 
plot.ts(SMA(logsts,n=2),xlab = "Time", ylab = "Sales")
plot.ts(SMA(logsts,n=4),xlab = "Time", ylab = "Sales")
plot.ts(SMA(logsts,n=6),xlab = "Time", ylab = "Sales")
plot.ts(SMA(logsts,n=8),xlab = "Time", ylab = "Sales")
plot.ts(SMA(logsts,n=10),xlab = "Time", ylab = "Sales")

#3
decomposets <- decompose(logsts)#rozklasty ts na skladovi aditivnoi modeli
decomposets$trend    #sistematichna
decomposets$seasonal #periodichna       skladovi
decomposets$random   #haotichna
plot(decomposets) #usi grafici

adjustedts <- logsts - decomposets$seasonal #viluch sezonni yavischa
plot(adjustedts)

#4
sacf<- acf(logsts, lag.max = 100)#corelograma

##################################################################################

#1

#Simple Exponential Smoothing
logstsForecasts <- HoltWinters(adjustedts,beta=FALSE,gamma=FALSE)
logstsForecasts
logstsForecasts$fitted
plot(logstsForecasts) #
logstsForecasts$SSE #sum-of-squared-error

logstsForecasts2 <- forecast(logstsForecasts, h=20)
logstsForecasts2
par(mfrow=c(1,1))
plot(logstsForecasts2)

#Holt's Exponential Smoothing
logsHolt<- HoltWinters(adjustedts,gamma=FALSE)
logsHolt
logsHolt$SSE
plot(logsHolt)
logsHolt2 <- forecast(logsHolt, h=20)
logsHolt2
plot(logsHolt2)
#Holt-Winters
logsHW<- HoltWinters(adjustedts)
logsHW
logsHW$SSE
plot(logsHW)
logsHW2 <- forecast(logsHolt, h=20)
logsHW2
plot(logsHW2)

#ARIMA model avtoregresii i ruh ser
auto.arima(logsts)
#parametri
#avtoregresii 2
#riznici 0
#zminnogo serednogo 0
tsarima <- arima(logsts, order = c(2, 0, 0))
arimafor <- forecast(tsarima, h=20)
plot(arimafor)
plot.ts(arimafor$residuals)
acf(arimafor$residuals, lag.max = 100)
mean(arimafor$residuals)

#2
#Simple
rr<-logstsForecasts2$residuals
plot(logstsForecasts2$residuals, ylab="residuals")
acf(rr, lag.max = 20,na.action = na.pass,main="Correlogram of Residuals")

help("acf")
