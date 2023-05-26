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

    Repository Pattern
        Aqui vamos organizar o nosso código para acessar dados
        Vamos criar Repositórios que é uma forma única de acesso a dados para cada entidade (também é possível criar um repositório que a atenda a mais de uma entidade/modelo)
        Tudo que for fazer vamos pasar pelos repositórios antes 
    
    UserRepository
        Tirar o static da classe pois o static impede a classe de ser instanciada
        Tirar o void pois ele não retornada e só imprime o nome do usuário
            Aqui devemos buscar os usuários e retornar os usuários para quem chamou
            Vamos mudar a assinatura desse usuário
            Trocar o void para IEnumerable porque o Get retorna um IEnumerable
            Apagar o foreach pois já tem Get e só vamos retornar o IEnumerable dele


*/