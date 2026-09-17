# CobranCM

Projeto ASP.NET para gestao de cobrancas.

## Estrutura

- `src/CobranCM.Api`: entrada HTTP da aplicacao.
- `src/CobranCM.Application`: casos de uso, contratos e regras de aplicacao.
- `src/CobranCM.Domain`: entidades, value objects e regras de dominio.
- `src/CobranCM.Infrastructure`: banco, envio de e-mail e integracoes externas.

## Dependencias

Fluxo esperado das referencias:

`Api -> Application -> Domain`

`Api -> Infrastructure -> Application -> Domain`
