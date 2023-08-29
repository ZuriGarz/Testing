#TP062964 Valentino Jaya Lay

#call the library tools
library(dplyr)
library(readr)
#rental house based on their family background, locality and lifestyle and provide meaningful insight for decision making

#Use Function (THIS IS A MUST because the function will be needed as the user may input many times)


DataHouseRent<- read.csv(file="C:/School and stuffs/PFDA Assignment/House_Rent_Dataset.csv")

#make a data set of price over Size group by the Furnishing status
Furnished = filter(DataHouseRent, Furnishing.Status=='Furnished')
UnFurnished = filter(DataHouseRent, Furnishing.Status=='Unfurnished')
SemiFurnished = filter(DataHouseRent, Furnishing.Status=='Semi-Furnished')




#make a data set of price over Size group by the Furnishing status
#below 10000 Economical
FurnishedEco = filter(DataHouseRent, Furnishing.Status=='Furnished', Rent<=10000)
UnFurnishedEco = filter(DataHouseRent, Furnishing.Status=='Unfurnished', Rent<=10000)
SemiFurnishedEco = filter(DataHouseRent, Furnishing.Status=='Semi-Furnished',Rent<=10000)
#Below 50000 Middle
FurnishedMid = filter(DataHouseRent, Furnishing.Status=='Furnished', Rent<=50000, Rent>10000)
UnFurnishedMid = filter(DataHouseRent, Furnishing.Status=='Unfurnished', Rent<=50000, Rent>10000)
SemiFurnishedMid = filter(DataHouseRent, Furnishing.Status=='Semi-Furnished',Rent<=50000, Rent>10000)
#Below 100000 UpperLevelPrice
FurnishedUp = filter(DataHouseRent, Furnishing.Status=='Furnished', Rent<=1000000, Rent>50000)
UnFurnishedUp = filter(DataHouseRent, Furnishing.Status=='Unfurnished', Rent<=1000000, Rent>50000)
SemiFurnishedUp = filter(DataHouseRent, Furnishing.Status=='Semi-Furnished',Rent<=1000000, Rent>50000)
#Upper 100000 SuperExpensive
FurnishedEX = filter(DataHouseRent, Furnishing.Status=='Furnished', Rent>100000)#Which currently unavailable
UnFurnishedEX = filter(DataHouseRent, Furnishing.Status=='Unfurnished', Rent>100000)#which currently unavailable
SemiFurnishedEX = filter(DataHouseRent, Furnishing.Status=='Semi-Furnished',Rent>100000)

#Finds the highest price 
Price <- max(DataHouseRent$Rent)
Price

Highest <- filter(DataHouseRent, Rent==3500000)


Size<- max(DataHouseRent$Size)

HighestSize <- filter(DataHouseRent, Size==8000)



#plotting Graph
plot(DataHouseRent$Size,DataHouseRent$Rent, xlab = "Size", ylab="RentPrice", main = "Price over Size")
#assign to variable

#Removing the outlierfor price 
dataa <- DataHouseRent$Rent
#removing outlier in price as it affect the overall deduction in box plot
quartiles <- quantile(dataa, probs=c(.25, .75), na.rm = FALSE)
IQR <- IQR(dataa)
Lower <- quartiles[1] - 1.5*IQR
Upper <- quartiles[2] + 1.5*IQR 
data_no_outlier <- subset(dataa, dataa > Lower & dataa < Upper)
length(data_no_outlier)
Name = c("Rentprice")
boxplot(data_no_outlier)



#finding min price without outlier which are over priced
print(Upper)

#from here we can filter the data of non outlier 
FurnishedOutFree = filter(DataHouseRent, Furnishing.Status=='Furnished', Rent>=67500)
UnFurnishedOutFree = filter(DataHouseRent, Furnishing.Status=='Unfurnished', Rent>=67500)
SemiFurnishedOutFree = filter(DataHouseRent, Furnishing.Status=='Semi-Furnished',Rent>=67500)


mean(FurnishedOutFree[["Rent"]])
mean(UnFurnishedOutFree[["Rent"]])
mean(SemiFurnishedOutFree[["Rent"]])


mean(FurnishedOutFree[["Size"]])
mean(UnFurnishedOutFree[["Size"]])
mean(SemiFurnishedOutFree[["Size"]])
