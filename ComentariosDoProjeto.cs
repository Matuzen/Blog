/* 
    Por padrão o Dapper Contrib tenta pluralizar a nossa entidade (User)
    Aqui o Dapper Contrib vai buscar no banco de dados a tabela Users
    Normalmente nomes de pastas são no plural e aquivos no singular
    Para resolver isso vamos usar uma Notação (também chamada de Metadados) são informações adicionais que podemos passar sobre uma classe
    Esse metadados estão no Program.cs linha 3 
    Embora essa classe se chame User, o Dapper Contrib vai buscar na tabela o nome da tabela


    CreatUser() 
        Este método precisa do objeto usuário (fazer uma instanciação do objeto) e entre chaves os dados do usuário
        para salvar o usuário precisa mudar o Get para Insert

    UpdateUser()
        No Update precisa passar o Id 
    
    DeleteUser()
        No caso do Delete é interessante ao invés de instanciar o objeto, vamos recuperar ele do banco
        Vamos pegar a Tabela User e selecionar o usuário 2 conforme no código


*/