/* 
    Por padrão o Dapper Contrib tenta pluralizar a nossa entidade (User)
    Aqui o Dapper Contrib vai buscar no banco de dados a tabela Users
    Normalmente nomes de pastas são no plural e aquivos no singular
    Para resolver isso vamos usar uma Notação (também chamada de Metadados) são informações adicionais que podemos passar sobre uma classe
    Esse metadados estão no Program.cs linha 3 
    Embora essa classe se chame User, o Dapper Contrib vai buscar na tabela o nome da tabela

*/