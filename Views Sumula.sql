
create view SumulaDados
as
select s.idsumula, j.nomeJogador as 'Jogador', jg.idJogo as 'Identificação do Jogo', e.nomeEquipe as 'Time Casa', e1.nomeEquipe as 'Time Fora', s.gol, s.cartao
from Sumula s inner join Jogador j on s.idJogador = j.idJogador
			  inner join Jogo jg on jg.idJogo = s.idJogo
			  inner join Equipe e on e.idEquipe = jg.idEquipe1
			  inner join Equipe e1 on e1.idEquipe = jg.idEquipe2

create view TimeSumula
as
select j.idJogo, concat(e.nomeEquipe,' x ', e1.nomeEquipe) as 'Jogo'
from Jogo j inner join Equipe e on e.idEquipe = j.idEquipe1
			inner join Equipe e1 on e1.idEquipe = j.idEquipe2