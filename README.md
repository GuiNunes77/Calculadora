# Projeto
Calculadora com as operações básicas e manter histórico das últimas 3 operações.

## Metodologia
TDD - Test Driven Development (ou Desenvolvimento Orientado a Testes).

# Regras de Negócio
* Apenas números inteiros
* 2 parâmetros por operação
* Retornas as últimas 3 operações no histórico

# Testes Aplicados
## Cenários Positivos
- TesteSomar(int, int, int);
- TesteSubtrair(int, int, int);
- TesteMultiplicar(int, int, int);
- TesteDividir(int, int, int);
- TestarHistorico(List);

## Cenários Negativos
- DivisaoPorZero();
