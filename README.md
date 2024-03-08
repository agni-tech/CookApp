# Introduction 
The project was made out to attend the following requirements:
Help our master barbecue chef to optimize the order in which barbecue items are grilled. Since the space on the grill is limited and grill items have different sizes, you need to calculate an optimal schedule for grilling. The grill measures 20cm x 30cm. The cooking time is the same for all barbecue items.


# Explaining solution applied
The code GET data from an endpoint and getting this data calculates the number of rounds needed for grilling each menu. Finally, it returns the total number of rounds required for all menus.

#Projects created
- CookApp
- CookApp.Domain

The following folders were added to Domain project: 

    CookApp.Domain.Dtos
    CookApp.Domain.Entities
    CookApp.Domain.Services

Dtos: For handling items, and it's where the TotalAreaRequired() and CalculateRounds() methods are placed 
Entities: Where the MenuItem Class resides
Services: Uses System.Net.Http to get data from https://isol-grillassessment.azurewebsites.net/api/GrillMenu 

#Testing Program
- Open Visual Studio and hit F5
