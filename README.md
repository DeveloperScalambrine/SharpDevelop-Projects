# Controle de Lançamento de Foguetes - SCALAMBRINE

Este é um projeto desenvolvido para a empresa **SCALAMBRINE** com o objetivo de controlar os lançamentos de foguetes, gerenciar as metas de captura de pássaros terrestres, monitorar o nível de dor dos usuários em caso de insucesso e permitir o cadastramento e a visualização de parâmetros de voo. A solução utiliza **Windows Forms**, **SQLite** e a linguagem **C#**, com suporte à integração com o **GitHub**.

---

## Funcionalidades

- **Gerenciamento de Voos**:
  - Cadastro de novos voos.
  - Visualização de voos cadastrados em uma lista.
  - Edição de parâmetros de voos existentes.
  - Exclusão de voos.

- **Banco de Dados**:
  - Utilização do SQLite para armazenamento local dos dados.
  - Criação automática do banco de dados `acme.sqlite` caso ele não exista.

- **Regras de Negócio**:
  - Exibição de data, indicador de captura e nível de dor na lista de voos.
  - Operações de inclusão, exclusão, salva e cancelamento seguem fluxos definidos.

---

## Tecnologias Utilizadas

- **Linguagem de Programação**: C#
- **Interface Gráfica**: Windows Forms
- **Banco de Dados**: SQLite (via `System.Data.SQLite`)
- **IDE**: SharpDevelop
- **Controle de Versão**: Git (integração com GitHub)

---

## Estrutura do Banco de Dados

- **Arquivo do Banco**: `acme.sqlite`
- **Tabela**: `TB_VOO`

| Coluna        | Tipo            | Descrição                                    |
|---------------|-----------------|-----------------------------------------------|
| `ID_VOO`      | `INTEGER`       | Identificador único do voo (chave primária).   |
| `DATA_VOO`    | `DATETIME`      | Data do voo.                                  |
| `CUSTO`       | `NUMERIC(10,2)` | Custo do foguete.                             |
| `DISTANCIA`   | `INTEGER`       | Distância alcançada pelo foguete.               |
| `CAPTURA`     | `CHAR(1)`       | Indicador de captura de pássaro (S ou N).       |
| `NIVEL_DOR`   | `INTEGER`       | Nível de dor ao final do teste (0 a 10).        |

---

## Layout da Interface

- **Lista de Voos Cadastrados**: Exibe as informações de data, captura e nível de dor.
- **Formulário de Cadastro/Edição**:
  - Campos: Data do Voo, Custo, Distância, Captura (Radio Buttons para Sim/Não), e Nível de Dor.
  - Botões: Incluir, Excluir, Salvar, Cancelar.

---

## Regras de Negócio

1. **Iniciar o programa**:
   - Verifica se o arquivo `acme.sqlite` existe.
   - Caso não exista, cria o banco e a tabela `TB_VOO`.

2. **Exibição dos voos**:
   - Lista apenas `DATA_VOO`, `CAPTURA` e `NIVEL_DOR` no componente `ListView`.

3. **Seleção de voo**:
   - Exibe os detalhes completos do voo nos campos laterais para edição.

4. **Incluir voo**:
   - Limpa os campos e habilita a edição.

5. **Excluir voo**:
   - Deleta o voo selecionado com base no `ID_VOO`.

6. **Salvar alterações**:
   - Insere ou atualiza os dados no banco, dependendo do contexto.

7. **Cancelar alterações**:
   - Reverte os campos para o estado inicial.

---

## Instalação e Execução

### **Requisitos**
- .NET Framework 4.8 (ou superior).
- SharpDevelop instalado.
- NuGet configurado para gerenciamento de pacotes.

### **Passos**
1. Clone o repositório:
   ```bash
   git clone <URL-do-repositorio>
   ```
2. Abra o projeto no SharpDevelop.
3. Restaure os pacotes NuGet:
   ```bash
   nuget install System.Data.SQLite
   ```
4. Compile e execute o projeto.

---

## Contribuições

Contribuições são bem-vindas! Siga os passos abaixo para colaborar:
1. Realize um fork do repositório.
2. Crie uma branch para sua feature ou bugfix:
   ```bash
   git checkout -b minha-feature
   ```
3. Envie suas alterações:
   ```bash
   git commit -m "Minha contribuição"
   git push origin minha-feature
   ```
4. Abra um Pull Request no repositório original.

---

## Licença

Este projeto está licenciado sob a Licença MIT. Veja o arquivo `LICENSE` para mais detalhes.

---

Se precisar de mais ajuda, entre em contato com a equipe de desenvolvimento.

---

**Desenvolvido por:** SCALAMBRINE Tech Solutions 🚀

