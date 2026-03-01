# 🎮 Jo-Ken-Po (Pedra, Papel e Tesoura) em C#

Mini jogo de **Pedra, Papel e Tesoura** desenvolvido em **C#** para execução no console.
O jogador escolhe uma opção e o computador faz uma escolha aleatória. O sistema compara os resultados e exibe quem venceu.

---

## 📌 Sobre o Projeto

Este projeto foi criado com o objetivo de praticar:

* Estruturas condicionais (`if / else`)
* Enumerações (`enum`)
* Geração de números aleatórios com `Random`
* Entrada e saída de dados no console
* Estrutura básica de um programa C#

---

## 🛠 Tecnologias Utilizadas

* C#
* .NET
* Console Application

---

## 🚀 Como Executar o Projeto

### 1️⃣ Clonar o repositório

```bash
git clone https://github.com/GabeDebug/Jo-Ken-Po
```

### 2️⃣ Acessar a pasta do projeto

```bash
cd Jo_Ken_PO
```

### 3️⃣ Executar o projeto

```bash
dotnet run
```

---

## 🎮 Como Jogar

Ao iniciar o programa, será exibido o menu:

```
1 - Pedra
2 - Papel
3 - Tisoura
4 - Sair
```

Digite o número correspondente à sua escolha e pressione **Enter**.

O computador fará uma escolha aleatória e o resultado será exibido:

* Empate
* Você venceu
* Você perdeu

---

## 🧠 Lógica do Jogo

As regras aplicadas são:

| Jogador      | Computador | Resultado        |
| ------------ | ---------- | ---------------- |
| Pedra        | Tesoura    | Jogador vence    |
| Papel        | Pedra      | Jogador vence    |
| Tesoura      | Papel      | Jogador vence    |
| Igual        | Igual      | Empate           |
| Outros casos | -          | Computador vence |

O computador escolhe um número aleatório entre **1 e 3** usando:

```csharp
Random random = new Random();
int computador = random.Next(1,4);
```

---

## 📂 Estrutura do Código

O projeto possui:

* `enum Escolhas` → Representa Pedra, Papel e Tesoura
* `Main()` → Responsável por:

  * Exibir o menu
  * Ler a escolha do jogador
  * Gerar a escolha do computador
  * Comparar resultados
  * Mostrar o vencedor

---

## 📚 Conceitos Praticados

* Enumeração em C#
* Estruturas condicionais
* Lógica booleana
* Manipulação de console
* Organização básica de código

---

## 🔮 Possíveis Melhorias

* Implementar validação de entrada
* Implementar a opção "Sair"
* Transformar em jogo com várias rodadas
* Exibir o nome da escolha em vez do número
* Adicionar placar

---

## 👨‍💻 Autor

Desenvolvido para fins de estudo e prática em C#.

---

