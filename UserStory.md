Store and manage game titles, searchable and organized by genre & game system. (DO NOT create a class called "System", this can get confusing) 


Game, GameSystem, Genre (Stretch goals: Rating, Price, Release Date)




User Stories:
USER STORY 1:
User: Reginald - an owner and operator of a video game store
---------------------------------------------------------------------------------------------------------------------
User Use: He would like to add games to a database including the game genre and game system, and price of the game.
---------------------------------------------------------------------------------------------------------------------
Test: Post game title genre, game system, and price should get 200 ok  unless it's over 225 or is missing a title, genre, game system, or price  then it should return as a 400 bad request.
---------------------------------------------------------------------------------------------------------------------


USER STORY 2:
User: Gwendolyn - a mother looking to purchase kid friendly games
---------------------------------------------------------------------------------------------------------------------
User Use: She would like to search the database to find games that are considered kid friendly.
---------------------------------------------------------------------------------------------------------------------
Test: Get title by maturity ratings should get 200 ok unless maturity rating doesn't exist then should return with 404 not found.
---------------------------------------------------------------------------------------------------------------------


USER STORY 3:
User: Archibald - an arrogant game enthusiast
---------------------------------------------------------------------------------------------------------------------
User Use: He would like to update the database when he finds errors.
---------------------------------------------------------------------------------------------------------------------
Test: Send an update to the database should get a 200 ok unless the title does not exist then should get 404 not found.
---------------------------------------------------------------------------------------------------------------------








USER STORY 4:
User: Wallace - a worker at Entertainment Software Rating Board
---------------------------------------------------------------------------------------------------------------------
User Use: He would like to delete entries from the database when a game is added to a ban list.
---------------------------------------------------------------------------------------------------------------------
Test: Delete item from database should get a 200 ok when deleted. If not able to delete should get a 400 bad request.
---------------------------------------------------------------------------------------------------------------------


USER STORY 5:
User: Dwight - a gamer who only owns a Nintendo DS
---------------------------------------------------------------------------------------------------------------------
User Use: He would like to search for games that are only available on the Nintendo DS platform. 
---------------------------------------------------------------------------------------------------------------------
Test: Get title by game system should get 200 ok unless game system doesn't exist then should return with 404 not found.
---------------------------------------------------------------------------------------------------------------------
USER STORY 6:
User: Antiochus - a game executive at Maxis
---------------------------------------------------------------------------------------------------------------------
User Use: He would like to add titles to the database for upcoming games. 
---------------------------------------------------------------------------------------------------------------------
Test: Post game title should get 200 ok  unless it's over 225 then it should return as a 400 bad request.
---------------------------------------------------------------------------------------------------------------------


USER STORY 7:
User: Rhaegar - a writer at IGN
---------------------------------------------------------------------------------------------------------------------
User Use: He would like to update the game console associated with a particular game, when it is released on a new game console.
---------------------------------------------------------------------------------------------------------------------
Test: Send an update to the database should get a 200 ok unless the title or console does not exist then should get 404 not found.
---------------------------------------------------------------------------------------------------------------------






USER STORY 8:
User: Hippocratesr - a game reviewer
---------------------------------------------------------------------------------------------------------------------
User Use: He would like to update the game genre when a new genre is created that better fits a particular game.
---------------------------------------------------------------------------------------------------------------------
Test: Send an update to the database should get a 200 ok unless the title or genre does not exist then should get 404 not found.
---------------------------------------------------------------------------------------------------------------------


USER STORY 9:
User: Aaron - a cheapskate
---------------------------------------------------------------------------------------------------------------------
User Use: He would like to search for the cheapest possible games available.
---------------------------------------------------------------------------------------------------------------------
Test: Get title by price should get 200 ok unless price doesn't exist then should return with 404 not found.
---------------------------------------------------------------------------------------------------------------------


USER STORY 10:
User: Jacob - an MMO enthusiast
---------------------------------------------------------------------------------------------------------------------
User Use: He would like to search games that fit his favorite genre.
---------------------------------------------------------------------------------------------------------------------
Test: Get title by genre should get 200 ok unless genre doesn't exist then should return with 404 not found.
---------------------------------------------------------------------------------------------------------------------


USER STORY 11:
User: Jason - sports mania
---------------------------------------------------------------------------------------------------------------------
User Use: He would like to receive a list of games that are related to sports.
---------------------------------------------------------------------------------------------------------------------
Test: Get title by genre should get 200 ok unless genre doesn't exist then should return with 404 not found.
---------------------------------------------------------------------------------------------------------------------












Tickets:


              S: 1 point - easy
             M: 2 points - pretty easy
                 L: 3 points - mediocre
    XL: 5 points - difficult
          XXL: 8 points - complicated 
        XXXL: 13+ points - epic
