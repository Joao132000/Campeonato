## Campeonato (Soccer Tournament)

This project was developed in C# using Windows forms App (.NET Framework). The database was Microsoft SQL Server. The software “Campeonato” basically was developed to organize soccer tournaments.

### Database Diagram
Jogador = Player

Campeonato = Tournament

Equipe = Team				

Estadio = Stadium/Field

Sumula = Records of the match		

Organizacao_Campeonato = Tournament Organization

Jogo = Game
 
<img width="565" alt="image" src="https://user-images.githubusercontent.com/71353908/225515914-188e3597-646c-4be1-ba32-84dd3ea3d0f9.png">

### Home Page
Buttons on the left are mainly for data registration such as to add new players, edit a team, or delete a stadium from the database. Buttons on the right side are for the tournament creation and organization.  
 
<img width="547" alt="image" src="https://user-images.githubusercontent.com/71353908/225516068-16be3cb7-71ff-4211-8423-ae065d064d33.png">

### Team 
Here a new team can be added to the database as well as deleted and updated. Required fields are name of the team, city and logo. Also, it is possible to check all teams already in the database and filter by the team’s name.

<img width="553" alt="image" src="https://user-images.githubusercontent.com/71353908/225516134-814325c1-ab32-4674-98df-15c7e6a9a1a0.png">

### Player
This form works as the previous one, but for players. Each player must be linked to a team previously added to the database.
 
<img width="548" alt="image" src="https://user-images.githubusercontent.com/71353908/225516194-b2f82fb4-324f-4db0-894e-df57dfb4232e.png">

The “Relatorio de Jogadores” button lists all players on their respective teams.
 
<img width="565" alt="image" src="https://user-images.githubusercontent.com/71353908/225516236-25d7ae25-0501-4308-9f98-09885787f50d.png">

### Stadium and Tournament
It works just like the players and teams’ forms. It is possible to create a new, update, and delete a stadium or a tournament.
 
<img width="554" alt="image" src="https://user-images.githubusercontent.com/71353908/225516264-8f707784-a8cb-47ab-9462-aecbf2ab75af.png">

### Adding teams to a new tournament
Choose a tournament previously registered. Select all teams that are going to participate in the tournament, after selecting each team press the button “Adicionar”. Press the button “Finalizar” to finish the process of adding teams.

<img width="547" alt="image" src="https://user-images.githubusercontent.com/71353908/225516298-e3b3f4d0-9500-487e-8283-8a707e5d34fb.png">
 
### Creating Game
Select the tournament, then all teams that are playing in this tournament are going to be available to be chosen. Select one of the teams to play at home and another one to play away. Select the stadium and pick a date for the game.

<img width="556" alt="image" src="https://user-images.githubusercontent.com/71353908/225516342-e8e21ec4-7beb-4f0e-b13b-16d4a487ade7.png"> 

The “Relatorio de Jogos Marcados” button reports all games divided by tournament. 

<img width="568" alt="image" src="https://user-images.githubusercontent.com/71353908/225516383-08c1a86d-3d7b-4729-8166-d7b105ffbdd5.png">

### Game
Choose a tournament and all games registered for that tournament (games that have not yet happened) are going to be available. Set the time and press “Iniciar Jogo” to start the game.
 
<img width="546" alt="image" src="https://user-images.githubusercontent.com/71353908/225516408-fb7e2802-609e-48f5-997c-612c7228aa05.png">
 
When someone scores press the button “Preecher Sumula” to report the goal.

<img width="558" alt="image" src="https://user-images.githubusercontent.com/71353908/225516441-cb0e64a0-c069-4c8e-b945-d07ba665d9c0.png">

Select the team and the player who scored the goal and save the information.

<img width="544" alt="image" src="https://user-images.githubusercontent.com/71353908/225516487-b72fd64b-6663-43f9-8807-aebf4136ed73.png">

The score automatically updates
 
<img width="542" alt="image" src="https://user-images.githubusercontent.com/71353908/225516536-85f402c7-4b42-462b-8149-c5c5972cd8ed.png">

### Standings
After the game is complete, the score will be visible in the “classificação” button. Also the standings are automatically updated after every game. The winner gets 3 points, loser 0, and if it is a tie each team gets 1 point.

<img width="545" alt="image" src="https://user-images.githubusercontent.com/71353908/225516601-645a36a1-f992-4cbc-bc4b-a9d90bcd3621.png">

<img width="552" alt="image" src="https://user-images.githubusercontent.com/71353908/225516643-b3012871-c9ec-4ba2-8d1f-2adbbe01da6d.png">
