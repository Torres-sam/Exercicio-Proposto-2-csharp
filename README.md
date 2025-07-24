# 📐 Calculadora de Área de Círculo - C#

Este é um programa simples em C# que calcula a área de um círculo a partir do valor do raio informado pelo usuário.

## 🧮 Funcionalidade

O programa:
- Solicita que o usuário insira o valor do raio;
- Calcula a área do círculo usando a fórmula:  
  Área = π × raio × raio**
- Exibe o resultado com 4 casas decimais.

> O código também demonstra duas formas diferentes de realizar o mesmo cálculo.

## 💻 Tecnologias Utilizadas

- Linguagem: **C#**
- Framework: **.NET**
- Namespace: `System`, `System.Globalization`

## ▶️ Como Executar

bash
git clone https://github.com/Torres-sam/Exercicio-Proposto-2-csharp.git
cd nome-do-repositorio
Compile e execute o programa com o .NET CLI:

bash
dotnet run
Insira o valor do raio quando solicitado.

📄 Exemplo de Saída

Qual o valor do raio: 2.0
A área do círculo é: 12.5664

📦 Estrutura do Projeto

ExercicioProposto2/
├── Program.cs
├── ExercicioProposto2.csproj
└── README.md

📌 Observações

O código utiliza CultureInfo.InvariantCulture para garantir a formatação correta de números decimais, independente da localidade do sistema.

Há duas abordagens para o cálculo, mostrando o uso de Math.PI e uma constante personalizada (p = 3.14159).

