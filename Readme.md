# Requisitos para Desenvolvimento do Sistema Dlink DFE

O objetivo deste projeto é desenvolver o frontend do sistema Dlink DFE. Este sistema irá fornecer aos usuários uma interface amigável para gerenciar documentos fiscais. A seguir, estão os requisitos detalhados para o desenvolvimento da aplicação.

## 1. Estrutura da Página Principal (Home)
<details>
<summary><strong>Mais informações:</strong></summary>

### 1.1. Menu de Navegação Superior
O menu de navegação deve estar localizado na parte superior da página principal (home). À esquerda do menu, deve ser exibida a logo da empresa. À direita do menu, devem ser exibidos, nesta ordem, da esquerda para a direita:
- **Botão de sair:** Um botão que permite ao usuário fazer logout do sistema.
- **Central de Dúvidas:** Um ícone ou botão que, ao ser clicado, abre uma seção de FAQ ou informações de ajuda.
- **Foto do Usuário Logado:** Mostra a imagem do perfil do usuário. Ao clicar na foto, deve abrir o perfil do usuário.

### 1.2. Menu Lateral (Hambúrguer)
Abaixo do menu de navegação, deve haver um botão de menu sanduíche (hambúrguer) que, ao ser clicado, abre um menu lateral. O menu lateral deve conter as seguintes opções:
- **Início:** Redireciona para a página principal (home).
- **Documentos Emitidos:** Redireciona para a página onde os documentos fiscais emitidos são exibidos em uma tabela.

</details>

## 2. Página de Documentos Emitidos
<details>
<summary><strong>Mais informações:</strong></summary>

### 2.1. Filtros de Pesquisa
Acima da tabela de documentos, deve haver um campo de filtros que permite aos usuários filtrar os resultados. Os filtros devem incluir opções para selecionar um ou mais critérios simultaneamente. Deve haver um botão "Aplicar" que, ao ser clicado, aplica os filtros selecionados e atualiza a tabela de documentos. Os filtros devem incluir:
- **NFE e NFC-E**: Somente tipos de documentos fiscais eletrônicos.
- **Ordenação por Colunas:** Permite ordenar a tabela de documentos pelos diferentes campos.

### 2.2. Tabela de Documentos
A tabela de documentos deve ser exibida com as seguintes colunas (da esquerda para a direita):
- **Checkbox para Seleção:** Permite ao usuário selecionar um ou mais documentos.
- **Status:** Mostra o status do documento, que pode ser "Autorizado", "Cancelado", "Inutilizado", ou "Pendente".
- **Modelo:** Mostra o modelo do documento, que pode ser 55 ou 65.
- **Número:** Exibe o número do documento.
- **Série:** Exibe a série do documento.
- **Emissão:** Mostra a data de emissão do documento.
- **Destinatário:** Exibe o nome do destinatário do documento.
- **Valor:** Exibe o valor total do documento.

### 2.3. Controle de Paginação e Visualização
Abaixo da tabela, deve haver um controle de visualização e paginação:
- **À Esquerda:** Um dropdown que permite ao usuário escolher a quantidade de linhas a serem exibidas na tabela por página. As opções devem ser: 25, 50 (padrão), 75, ou 100 linhas.
- **À Direita:** Um controle de paginação com botões para navegar entre as páginas:
  - **Anterior:** Move para a página anterior.
  - **Sequência de Páginas:** Mostra um conjunto de até 8 números de páginas que o usuário pode selecionar.
  - **Próxima:** Move para a próxima página.

### 2.4. White Label
- **Cores Carregadas em Tempo de Execução:** O sistema deve carregar cores diferentes dependendo do cliente:
  - **Cores Dlink:** Para clientes Dlink (IDs de 1 a 5000).
  - **Cores Prime:** Para clientes Prime (IDs acima de 5000).
  - A ideia é passar uma query com o código da empresa para determinar as cores a serem aplicadas.

</details>

## 3. Comportamentos Esperados
<details>
<summary><strong>Mais informações:</strong></summary>

- O menu de navegação superior deve permanecer fixo no topo da página durante a rolagem.
- O menu lateral deve deslizar para dentro e para fora ao ser acionado pelo botão de menu sanduíche.
- Os filtros devem ser aplicáveis em tempo real ou mediante o clique no botão "Aplicar".
- A tabela de documentos deve ser atualizada dinamicamente conforme os filtros são aplicados ou removidos.
- O controle de paginação deve permitir uma navegação suave e eficiente entre as páginas de documentos.
- **Textos à Direita:** Dados e valores devem estar alinhados conforme solicitado.
- **Datas Centralizadas:** As datas devem estar centralizadas nas colunas.
- **Valores à Esquerda:** Os valores devem estar alinhados à esquerda.

</details>
