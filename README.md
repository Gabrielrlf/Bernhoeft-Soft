# Bernhoeft

## Como utilizar
A aplicação conta com uma documentação via swagger para facilitar seu uso.
Para rodar, caso utilize o visual studio é só setar a api principal para startar.

Tentei deixar a aplicação o mais simples possível, também por conta do tempo p/ entrega-la.

### 1.1 - Métodos Post
##PRODUTO
#### Salvar/Criar Produto - ![image](https://user-images.githubusercontent.com/49160989/209032035-5715794b-c86f-4bce-ba74-c87fbf35ae90.png)
Caso a categoria não exista ele irá criar.  Passe a descrição, situação, nome do produto e o preço e clique para enviar as informações. 

##CATEGORIA
#### Salvar/Criar Categoria ![image](https://user-images.githubusercontent.com/49160989/209032342-75c8f68f-9b98-44b3-b817-adb5e0ffa9b3.png)
Bem semelhante ao produto, apenas setar os valores e clicar para enviar.

### 1.2 - Métodos Get
##PRODUTO
#### Buscar produtos - ![image](https://user-images.githubusercontent.com/49160989/209032540-bd5bb782-f693-4393-b978-3413adbca105.png)
Para buscar os produtos você pode passar os filtros (por padrão o filterActive/situation está como false) e efetuar o get, ele irá retornar conforme vc passou os filtros no formquery.

##CATEGORIA
#### Buscar categorias - ![image](https://user-images.githubusercontent.com/49160989/209032695-926e26d8-adf4-4732-8ec0-4d2b5ef20e0d.png)
Para buscar as categorias é bem semelhante ao produto, só passar os filtros e efetuar o get e ele irá retornar conforme vc passou os filtros no formquery.

### 1.3 - Métodos put
##PRODUTO
#### Alterar produto existente - ![image](https://user-images.githubusercontent.com/49160989/209032857-af9b08ce-3cb5-4683-842a-c182c8a2f1e9.png)
Você vai passar o ID no body da requisição e enviar as novas propriedades, tendo isso em vista ela irá alterar toda a sua propriedade com as informações que você passou.

##CATEGORIA
#### Alterar categoria existente - ![image](https://user-images.githubusercontent.com/49160989/209032961-3d73a20e-1d4d-41d4-852f-aab9d1c5ed6e.png)
Semelhante ao de produtos, vai passar as novas informações com o id na requisição e a aplicação irá fazer a alteração.



## Tecnologias utilizadas

<table>
  <tr>
    <td>DOT NET 5</td>
    <td>C#</td>
    <td>EF CORE</td>
    <td>SQLite</td>
    <td>Repository Patterns</td>
    <td>Modelagem DDD</td>
</table>
