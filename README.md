# Dynamic Depth Of Field

## Autoria

Paulo Silva, a22206205;

## [>Repositório Git<](https://github.com/Pninja12/ComputacaoGraficaFinal)

### Descrição

#### Como decidi escolher este projecto

Ao analisar os projectos recomendados pelo professor e ao ver desenvolvedores falaram sobre o assunto, eu descobri um [vídeo](https://www.youtube.com/watch?v=7od2j4s85ww) onde um criador de conteúdo tenta descobrir uma maneira de dinamizar o uso do Depth Of Field. Com o meu interesse obtido, decidi então escolher este projeto.

Comecei por ir pesquisar assets de dimensões consideráveis para demonstrar a diferença de  proximidade e o efeito requerido, acabando por encontrar dois assets que me permitiriam demonstrar o efeito. Infelizmente um dos assets estava com problemas a ser implementado então decidi ir com a segunda escolha.
Ao pesquisar por tutoriais, encontrei [este](https://www.youtube.com/watch?v=7od2j4s85ww) que me ajudou a implementar o código necessário.
Ao finalizar, o efeito não estava a funcionar de todo e por isso tive de descer a versão do unity para 2022.3.3f1 .

#### Código

O único script implementado começa com 5 variáveis que podem ser editadas dentro do unity, em que cada uma delas é, respetivamente, sobre a distancia mínima da câmera até um objeto; a distancia máxima, caso não se encontre objeto nenhum; a velocidade a que o foco muda; se é usado uma esfera ou um ponto para detetar um objeto; e por último o raio da esfera.
Neste projeto não usei a esfera, mesmo que no tutorial tenha sido sujerido dado à grande inconsistência de mirar precisamente no objeto, porém eu senti o contrário, ao usar a esfera, um objeto que estava mais próximo de mim, tapa o objeto que eu realmente queria ver.
O script começa por receber o Post Process Volume, que é o objeto que controla o Depth Of Field, em seguida começa o loop normal do jogo. A cada Update, o script calcula se está a tocar em algum objeto, se não, então usa a distancia máximo, mas caso esteja a tocar, calcula a que distancia está o objeto e o foco a ser utilizado, até que a distancia se altere.

#### Como "jogar"

Para mexer o jogador basta usar o WASD para mosver para a frente, lado direito, atrás e lado esquerdo respetivamente, e olhar com o movimento do rato.

### Links:
#### Assets:
[primeira escolha](https://assetstore.unity.com/packages/3d/environments/sci-fi/free-sci-fi-office-pack-195067#content)(que não foi utilizada)

[segunda escolha](https://www.turbosquid.com/3d-models/3d-interior-model-2129438)(que foi utilizada)
        
#### Videos:
##### Demonstração:
[O video que me captou a curiosidade](https://www.youtube.com/watch?v=7od2j4s85ww)

##### Tutoriais:
[Video a explicar como implementar o Post Processing Volume](https://www.youtube.com/watch?v=nbxiqHCsYFg)

[Video a explicar onde no packet manager é que pesquiso](https://www.youtube.com/watch?v=wS5c14TmO5I)

[O tutorial principal](https://www.youtube.com/watch?v=F8aJb0X3-rs)
        
#### Documentação:
[Documentação do Unity](https://docs.unity3d.com/2018.1/Documentation/Manual/PostProcessing-DepthOfField.html)