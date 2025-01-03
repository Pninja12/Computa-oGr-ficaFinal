# Dynamic Depth Of Field

## Autoria

Paulo Silva, a22206205;

## [>Reposit�rio Git<](https://github.com/Pninja12/ComputacaoGraficaFinal)

### Descri��o

#### Como decidi escolher este projecto

Ao analisar os projectos recomendados pelo professor e ao ver desenvolvedores falaram sobre o assunto, eu descobri um [v�deo](https://www.youtube.com/watch?v=7od2j4s85ww) onde um criador de conte�do tenta descobrir uma maneira de dinamizar o uso do Depth Of Field. Com o meu interesse obtido, decidi ent�o escolher este projeto.

Comecei por ir pesquisar assets de dimens�es consider�veis para demonstrar a diferen�a de  proximidade e o efeito requerido, acabando por encontrar dois assets que me permitiriam demonstrar o efeito. Infelizmente um dos assets estava com problemas a ser implementado ent�o decidi ir com a segunda escolha.
Ao pesquisar por tutoriais, encontrei [este](https://www.youtube.com/watch?v=7od2j4s85ww) que me ajudou a implementar o c�digo necess�rio.
Ao finalizar, o efeito n�o estava a funcionar de todo e por isso tive de descer a vers�o do unity para 2022.3.3f1 .

#### C�digo

O �nico script implementado come�a com 5 vari�veis que podem ser editadas dentro do unity, em que cada uma delas �, respetivamente, sobre a distancia m�nima da c�mera at� um objeto; a distancia m�xima, caso n�o se encontre objeto nenhum; a velocidade a que o foco muda; se � usado uma esfera ou um ponto para detetar um objeto; e por �ltimo o raio da esfera.
Neste projeto n�o usei a esfera, mesmo que no tutorial tenha sido sujerido dado � grande inconsist�ncia de mirar precisamente no objeto, por�m eu senti o contr�rio, ao usar a esfera, um objeto que estava mais pr�ximo de mim, tapa o objeto que eu realmente queria ver.
O script come�a por receber o Post Process Volume, que � o objeto que controla o Depth Of Field, em seguida come�a o loop normal do jogo. A cada Update, o script calcula se est� a tocar em algum objeto, se n�o, ent�o usa a distancia m�ximo, mas caso esteja a tocar, calcula a que distancia est� o objeto e o foco a ser utilizado, at� que a distancia se altere.

#### Como "jogar"

Para mexer o jogador basta usar o WASD para mosver para a frente, lado direito, atr�s e lado esquerdo respetivamente, e olhar com o movimento do rato.

### Links:
#### Assets:
[primeira escolha](https://assetstore.unity.com/packages/3d/environments/sci-fi/free-sci-fi-office-pack-195067#content)(que n�o foi utilizada)

[segunda escolha](https://www.turbosquid.com/3d-models/3d-interior-model-2129438)(que foi utilizada)
        
#### Videos:
##### Demonstra��o:
[O video que me captou a curiosidade](https://www.youtube.com/watch?v=7od2j4s85ww)

##### Tutoriais:
[Video a explicar como implementar o Post Processing Volume](https://www.youtube.com/watch?v=nbxiqHCsYFg)

[Video a explicar onde no packet manager � que pesquiso](https://www.youtube.com/watch?v=wS5c14TmO5I)

[O tutorial principal](https://www.youtube.com/watch?v=F8aJb0X3-rs)
        
#### Documenta��o:
[Documenta��o do Unity](https://docs.unity3d.com/2018.1/Documentation/Manual/PostProcessing-DepthOfField.html)