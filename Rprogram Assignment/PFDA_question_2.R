#import the function
library(dplyr)
#Read the csv file with a directory

DataData<- read.csv(file="C:/School and stuffs/PFDA Assignment/Demographic_Data_countryRegion.csv")


#Number 1 by country income group
HISP<-filter(DataData, Income.Group == 'High income')
UMSP<-filter(DataData, Income.Group == 'Upper middle income')
LMSP<-filter(DataData, Income.Group == 'Lower middle income')
LISP<-filter(DataData, Income.Group == 'Low income')



#HighIncome Countries
plot(HISP$Birth.rate,HISP$Internet.users, xlab = "BirthRate", ylab="Internet User", main = "High Income Country InternetUser/BirthRate")
#Upper middle income countries
plot(UMSP$Birth.rate,UMSP$Internet.users, xlab = "BirthRate", ylab="Internet User", main = "UpperMiddleIncome Country InternetUser/BirthRate")
#LowerMiddleIncome Countries
plot(LMSP$Birth.rate,LMSP$Internet.users, xlab = "BirthRate", ylab="Internet User", main = "LowerMiddleIncome Country InternetUser/BirthRate")
#LowInccom Countries
plot(LISP$Birth.rate,LISP$Internet.users, xlab = "BirthRate", ylab="Internet User", main = "Low Income Country InternetUser/BirthRate")


#Number2 Check how many countries are there
RegionCategory <- levels(factor(DataData$Country.Region))
print(RegionCategory)


# from here we can conclude that there are Africa, Asia, Europe, North America, Oceania, and South america


#Number 3
Africa<-filter(DataData, Country.Region == 'Africa')
Asia<-filter(DataData, Country.Region == 'Asia')
Europe<-filter(DataData, Country.Region == 'Europe')
NorthAmerica<-filter(DataData, Country.Region == 'North America')
Oceania <- filter(DataData, Country.Region == 'Oceania')
SouthAmerica <- filter(DataData, Country.Region == 'South America')

#Africa
plot(Africa$Birth.rate,Africa$Internet.users, xlab = "BirthRate", ylab="Internet User", main = "Africa Internetuser/BirthRate")
#Asia
plot(Asia$Birth.rate,Asia$Internet.users, xlab = "BirthRate", ylab="Internet User", main = "Asia Internetuser/BirthRate")
#Europe
plot(Europe$Birth.rate,Europe$Internet.users, xlab = "BirthRate", ylab="Internet User", main = "Europe Internetuser/BirthRate")
#North America
plot(NorthAmerica$Birth.rate,NorthAmerica$Internet.users, xlab = "BirthRate", ylab="Internet User", main = "North America Internetuser/BirthRate")
#Oceania
plot(Oceania$Birth.rate,Oceania$Internet.users, xlab = "BirthRate", ylab="Internet User", main = "Oceania Internetuser/BirthRate")
#South America
plot(SouthAmerica$Birth.rate,SouthAmerica$Internet.users, xlab = "BirthRate", ylab="Internet User", main = "South America Internetuser/BirthRate")













#Below this is wrong












#Africa
AFHISP<-filter(HISP, Country.Region == 'Africa')
AFUMSP<-filter(UMSP, Country.Region == 'Africa')
AFLMSP<-filter(LMSP, Country.Region == 'Africa')
AFLISP<-filter(LISP, Country.Region == 'Africa')



#HighIncome Countries
plot(AFHISP$Birth.rate,AFHISP$Internet.users, xlab = "BirthRate", ylab="Internet User", main = "High Income Country InternetUser/BirthRate")
#Upper middle income countries
plot(AFUMSP$Birth.rate,AFUMSP$Internet.users, xlab = "BirthRate", ylab="Internet User", main = "UpperMiddleIncome Country InternetUser/BirthRate")
#LowerMiddleIncome Countries
plot(AFLMSP$Birth.rate,AFLMSP$Internet.users, xlab = "BirthRate", ylab="Internet User", main = "LowerMiddleIncome Country InternetUser/BirthRate")
#LowInccom Countries
plot(AFLISP$Birth.rate,AFLISP$Internet.users, xlab = "BirthRate", ylab="Internet User", main = "Low Income Country InternetUser/BirthRate")



#Asia
ASHISP<-filter(HISP, Country.Region == 'Asia')
ASUMSP<-filter(UMSP, Country.Region == 'Asia')
ASLMSP<-filter(LMSP, Country.Region == 'Asia')
ASLISP<-filter(LISP, Country.Region == 'Asia')

#HighIncome Countries
plot(ASHISP$Birth.rate,ASHISP$Internet.users, xlab = "BirthRate", ylab="Internet User", main = "Asian country HighIncome")
#Upper middle income countries
plot(ASUMSP$Birth.rate,ASUMSP$Internet.users, xlab = "BirthRate", ylab="Internet User", main = "Asian Country UpperMiddleIncome")
#LowerMiddleIncome Countries
plot(ASLMSP$Birth.rate,ASLMSP$Internet.users, xlab = "BirthRate", ylab="Internet User", main = "Asian LowerMiddleIncome")
#LowInccom Countries
plot(ASLISP$Birth.rate,ASLISP$Internet.users, xlab = "BirthRate", ylab="Internet User", main = "Asian LowIncome")




#Europe
EUHISP<-filter(HISP, Country.Region == 'Europe')
EUUMSP<-filter(UMSP, Country.Region == 'Europe')
EULMSP<-filter(LMSP, Country.Region == 'Europe')
EULISP<-filter(LISP, Country.Region == 'Europe')


#HighIncome Countries
plot(EUHISP$Birth.rate,EUHISP$Internet.users, xlab = "BirthRate", ylab="Internet User", main = "Europe HighIncome")
#Upper middle income countries
plot(EUUMSP$Birth.rate,EUUMSP$Internet.users, xlab = "BirthRate", ylab="Internet User", main = "Europe UpperMiddleIncome")
#LowerMiddleIncome Countries
plot(EULMSP$Birth.rate,EULMSP$Internet.users, xlab = "BirthRate", ylab="Internet User", main = "Europe LowerMiddleIncome")
#LowInccom Countries
plot(EULISP$Birth.rate,EULISP$Internet.users, xlab = "BirthRate", ylab="Internet User", main = "Europe LowIncome")



#North America
NAHISP<-filter(HISP, Country.Region == 'North America')
NAUMSP<-filter(UMSP, Country.Region == 'North America')
NALMSP<-filter(LMSP, Country.Region == 'North America')
NALISP<-filter(LISP, Country.Region == 'North America')


#HighIncome Countries
plot(NAHISP$Birth.rate,NAHISP$Internet.users, xlab = "BirthRate", ylab="Internet User", main = "North America HighIncome")
#Upper middle income countries
plot(NAUMSP$Birth.rate,NAUMSP$Internet.users, xlab = "BirthRate", ylab="Internet User", main = "North America UpperMiddleIncome")
#LowerMiddleIncome Countries
plot(NALMSP$Birth.rate,NALMSP$Internet.users, xlab = "BirthRate", ylab="Internet User", main = "North America LowerMiddleIncome")
#LowInccom Countries
plot(NALISP$Birth.rate,NALISP$Internet.users, xlab = "BirthRate", ylab="Internet User", main = "North America LowIncome")






# Oceania
OCHISP<-filter(HISP, Country.Region == 'Oceania')
OCUMSP<-filter(UMSP, Country.Region == 'Oceania')
OCLMSP<-filter(LMSP, Country.Region == 'Oceania')
OCLISP<-filter(LISP, Country.Region == 'Oceania')



#HighIncome Countries
plot(OCHISP$Birth.rate,OCHISP$Internet.users, xlab = "BirthRate", ylab="Internet User", main = "Oceania HighIncome")
#Upper middle income countries
plot(OCUMSP$Birth.rate,OCUMSP$Internet.users, xlab = "BirthRate", ylab="Internet User", main = "Oceania UpperMiddleIncome")
#LowerMiddleIncome Countries
plot(OCLMSP$Birth.rate,OCLMSP$Internet.users, xlab = "BirthRate", ylab="Internet User", main = "Oceania LowerMiddleIncome")
#LowInccom Countries
plot(OCLISP$Birth.rate,OCLISP$Internet.users, xlab = "BirthRate", ylab="Internet User", main = "Oceania LowIncome")




#South America
SAHISP<-filter(HISP, Country.Region == 'South America')
SAUMSP<-filter(UMSP, Country.Region == 'South America')
SALMSP<-filter(LMSP, Country.Region == 'South America')
SALISP<-filter(LISP, Country.Region == 'South America')



#HighIncome Countries
plot(SAHISP$Birth.rate,SAHISP$Internet.users, xlab = "BirthRate", ylab="Internet User", main = "South America HighIncome")
#Upper middle income countries
plot(SAUMSP$Birth.rate,SAUMSP$Internet.users, xlab = "BirthRate", ylab="Internet User", main = "South America UpperMiddleIncome")
#LowerMiddleIncome Countries
plot(SALMSP$Birth.rate,SALMSP$Internet.users, xlab = "BirthRate", ylab="Internet User", main = "South America LowerMiddleIncome")
#LowInccom Countries
plot(SALISP$Birth.rate,SALISP$Internet.users, xlab = "BirthRate", ylab="Internet User", main = "South America LowIncome")


