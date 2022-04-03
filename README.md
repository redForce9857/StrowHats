# StrowHats

## This REPO was created for midterm project (COMPUTER ORGANIZATION)


### The project is very extreamly simple it just CRUD API  actualy there is no even databace API Can (DELETE, GET, GET(by id), POST, PATCH) 

ok let us see th code 

![image](https://user-images.githubusercontent.com/95775818/161423241-06462922-9201-48c5-bf59-8a1fcc33ac71.png)
### This Class (StrowHats) is kinda Entity class it responsible for requestin to "databace" wich meens (what kind of colums should be there)


![image](https://user-images.githubusercontent.com/95775818/161423404-0a87a9a1-9042-4885-a64f-a2011ae1e1aa.png)
### This Class our local DataBase(the full database will be on final Project)

![image](https://user-images.githubusercontent.com/95775818/161423434-0eb8ce97-5277-4067-958a-232e250dd390.png)
### This two Classes responsible for GET reques and Get by:id 

***Task<ActionResult<List<StrowHats>>>***  just takes from **StrowHats** and returning them  and geting by **ID** olso works same but thios time its use **FIND** methods by ID
  
  
![image](https://user-images.githubusercontent.com/95775818/161423852-cd428e28-dfa6-4e93-9010-cebaee10241d.png)
### In these classes We are getting argument from **SWAGGER**  and adding to the locall Database 
  
### UPDATE works the same but OverWriting each parametr to the new argument from SWAGGER 
  
  
![image](https://user-images.githubusercontent.com/95775818/161424074-8ce27ee8-70ca-4c5d-8e82-9f624e21a1b9.png)
#### and last one is DELETING  works like GET(id) and using method **REMOVE** 
  
![localhost_44319_swagger_index html](https://user-images.githubusercontent.com/95775818/161424539-ec6fd43f-206f-41ed-9f23-8d570c5dea3c.png)
