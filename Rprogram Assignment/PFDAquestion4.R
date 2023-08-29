df<-read.csv("C:/School and stuffs/PFDA Assignment/Movie_Ratings.csv")
Movie_Ratings<- df

str(Movie_Ratings)
summary(Movie_Ratings)

library(dplyr)
library(ggplot2)
library(lattice)

#Convert Genre And `Year of release` variable in to factor
Movie_Ratings$Genre<- as.factor(Movie_Ratings$Genre)
Movie_Ratings$Year.of.release<- as.factor(Movie_Ratings$Year.of.release)


#1)
Plot_1<-ggplot(Movie_Ratings, aes(x=Genre, y=Movie_Ratings$Budget..million..., fill=Genre)) +
  geom_boxplot()+labs(title="Plot of Budget  per Genre")
Plot_1


#2)Make category of years
Y2007<-filter(df, Year.of.release == '2007')
Y2008<-filter(df, Year.of.release == '2008')
Y2009<-filter(df, Year.of.release == '2009')
Y2010<-filter(df, Year.of.release == '2010')
Y2011<-filter(df, Year.of.release == "2011")



#Data for Tomato rate

#2007 Data
xyplot(Budget..million... ~ Rotten.Tomatoes.Ratings.., group=Genre, data=Y2007, 
       auto.key=list(space="right"), main ="Budget over Tomato rating 2007" ,
       jitter.x=TRUE, jitter.y=TRUE )
#2008 Data
xyplot(Budget..million... ~ Rotten.Tomatoes.Ratings.., group=Genre, data=Y2008, 
       auto.key=list(space="right"), main ="Budget over Tomato rating 2008" ,
       jitter.x=TRUE, jitter.y=TRUE )
#2009 Data
xyplot(Budget..million... ~ Rotten.Tomatoes.Ratings.., group=Genre, data=Y2009, 
       auto.key=list(space="right"), main ="Budget over Tomato rating 2009" ,
       jitter.x=TRUE, jitter.y=TRUE )
#2010 Data
xyplot(Budget..million... ~ Rotten.Tomatoes.Ratings.., group=Genre, data=Y2010, 
       auto.key=list(space="right"), main ="Budget over Tomato rating 2010" ,
       jitter.x=TRUE, jitter.y=TRUE )
#2011 Data
xyplot(Budget..million... ~ Rotten.Tomatoes.Ratings.., group=Genre, data=Y2011, 
       auto.key=list(space="right"), main ="Budget over Tomato rating 2011" ,
       jitter.x=TRUE, jitter.y=TRUE )









#Data for User Rate

#2007 Data
xyplot(Budget..million... ~ Audience.Ratings.., group=Genre, data=Y2007, 
       auto.key=list(space="right"), main ="Budget over User rating 2007" ,
       jitter.x=TRUE, jitter.y=TRUE )
#2008 Data
xyplot(Budget..million... ~ Audience.Ratings.., group=Genre, data=Y2008, 
       auto.key=list(space="right"), main ="Budget over User rating 2008" ,
       jitter.x=TRUE, jitter.y=TRUE )
#2009 Data
xyplot(Budget..million... ~ Audience.Ratings.., group=Genre, data=Y2009, 
       auto.key=list(space="right"), main ="Budget over User rating 2009" ,
       jitter.x=TRUE, jitter.y=TRUE )
#2010 Data
xyplot(Budget..million... ~ Audience.Ratings.., group=Genre, data=Y2010, 
       auto.key=list(space="right"), main ="Budget over User rating 2010" ,
       jitter.x=TRUE, jitter.y=TRUE )
#2011 Data
xyplot(Budget..million... ~ Audience.Ratings.., group=Genre, data=Y2011, 
       auto.key=list(space="right"), main ="Budget over User rating 2011" ,
       jitter.x=TRUE, jitter.y=TRUE )



#Data budget over genre

Plot_1<-ggplot(Movie_Ratings, aes(x=Genre, y=Movie_Ratings$Budget..million..., fill=Genre)) +
  geom_boxplot()+labs(title="Budget over on the genre")
Plot_1