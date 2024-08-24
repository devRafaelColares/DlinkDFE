<!DOCTYPE html>
<html lang="pt-BR">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Requisitos para Desenvolvimento do Sistema Dlink DFE</title>
    <style>
        body {
            font-family: Arial, sans-serif;
            line-height: 1.6;
            margin: 20px;
        }
        h1 {
            color: #333;
        }
        details {
            margin-bottom: 20px;
        }
        summary {
            cursor: pointer;
            font-weight: bold;
        }
        summary::marker {
            color: #007BFF;
        }
        ul {
            list-style-type: disc;
            margin-left: 20px;
        }
        li {
            margin-bottom: 10px;
        }
    </style>
</head>
<body>
    <h1>Requisitos para Desenvolvimento do Sistema Dlink DFE</h1>
    <p>O objetivo deste projeto é desenvolver o frontend do sistema Dlink DFE. Este sistema irá fornecer aos usuários uma interface amigável para gerenciar documentos fiscais. A seguir, estão os requisitos detalhados para o desenvolvimento da aplicação.</p>

    <details>
        <summary><strong>1. Estrutura da Página Principal (Home)</strong></summary>
        <ul>
            <li>
                <strong>1.1. Menu de Navegação Superior</strong>
                <p>O menu de navegação deve estar localizado na parte superior da página principal (home). À esquerda do menu, deve ser exibida a logo da empresa. À direita do menu, devem ser exibidos, nesta ordem, da esquerda para a direita:</p>
                <ul>
                    <li>Foto do usuário logado: Mostra a imagem do perfil do usuário.</li>
                    <li>Menu de dúvidas: Um ícone ou botão que, ao ser clicado, abre uma seção de FAQ ou informações de ajuda.</li>
                    <li>Botão de sair: Um botão que permite ao usuário fazer logout do sistema.</li>
                </ul>
            </li>
            <li>
                <strong>1.2. Menu Lateral (Hambúrguer)</strong>
                <p>Abaixo do menu de navegação, deve haver um botão de menu sanduíche (hambúrguer) que, ao ser clicado, abre um menu lateral. O menu lateral deve conter as seguintes opções:</p>
                <ul>
                    <li>Início: Redireciona para a página principal (home).</li>
                    <li>Documentos Emitidos: Redireciona para a página onde os documentos fiscais emitidos são exibidos em uma tabela.</li>
                </ul>
            </li>
        </ul>
    </details>

    <details>
        <summary><strong>2. Página de Documentos Emitidos</strong></summary>
        <ul>
            <li>
                <strong>2.1. Filtros de Pesquisa</strong>
                <p>Acima da tabela de documentos, deve haver um campo de filtros que permite aos usuários filtrar os resultados. Os filtros devem incluir opções para selecionar um ou mais critérios simultaneamente. Deve haver um botão "Aplicar" que, ao ser clicado, aplica os filtros selecionados e atualiza a tabela de documentos.</p>
            </li>
            <li>
                <strong>2.2. Tabela de Documentos</strong>
                <p>A tabela de documentos deve ser exibida com as seguintes colunas (da esquerda para a direita):</p>
                <ul>
                    <li>Checkbox para seleção: Permite ao usuário selecionar um ou mais documentos.</li>
                    <li>Status: Mostra o status do documento, que pode ser "Autorizado", "Cancelado", "Inutilizado", ou "Pendente".</li>
                    <li>Modelo: Mostra o modelo do documento, que pode ser 55 ou 65.</li>
                    <li>Número: Exibe o número do documento.</li>
                    <li>Série: Exibe a série do documento.</li>
                    <li>Emissão: Mostra a data de emissão do documento.</li>
                    <li>Destinatário: Exibe o nome do destinatário do documento.</li>
                    <li>Valor: Exibe o valor total do documento.</li>
                    <li>Ações: Uma coluna que contém um menu de ações (ícone de três pontos). Ao clicar neste menu, as seguintes opções devem ser exibidas:</li>
                </ul>
                <ul>
                    <li>Imprimir: Gera uma impressão do documento.</li>
                    <li>Arquivo XML: Baixa o arquivo XML do documento.</li>
                    <li>Enviar: Envia o documento para o destinatário.</li>
                    <li>Cancelar: Cancela o documento.</li>
                </ul>
            </li>
            <li>
                <strong>2.3. Controle de Paginação e Visualização</strong>
                <p>Abaixo da tabela, deve haver um controle de visualização e paginação:</p>
                <ul>
                    <li>À esquerda, um dropdown que permite ao usuário escolher a quantidade de linhas a serem exibidas na tabela por página. As opções devem ser: 25, 50 (padrão), 75, ou 100 linhas.</li>
                    <li>À direita, um controle de paginação com botões para navegar entre as páginas:</li>
                    <ul>
                        <li>Anterior: Move para a página anterior.</li>
                        <li>Sequência de páginas: Mostra um conjunto de até 8 números de páginas que o usuário pode selecionar.</li>
                        <li>Próxima: Move para a próxima página.</li>
                    </ul>
                </ul>
            </li>
        </ul>
    </details>

    <details>
        <summary><strong>3. Comportamentos Esperados</strong></summary>
        <p>O menu de navegação superior deve permanecer fixo no topo da página durante a rolagem. O menu lateral deve deslizar para dentro e para fora ao ser acionado pelo botão de menu sanduíche. Os filtros devem ser aplicáveis em tempo real ou mediante o clique no botão "Aplicar". A tabela de documentos deve ser atualizada dinamicamente conforme os filtros são aplicados ou removidos. O controle de paginação deve permitir uma navegação suave e eficiente entre as páginas de documentos.</p>
    </details>
</body>
</html>

