#include <iostream>
#include <locale.h>

using namespace std;


class Funcionario{
	private: 
		int prontuario;
		string nome;
		double salario; 
		
	public: 
		Funcionario(int prontuario, string nome, double salario){
			this->prontuario = prontuario;
			this->nome = nome;
			this->salario =  salario;
		}
		Funcionario(){
            this->prontuario = 0;
			this->nome = "";
			this->salario = 0.0;
		}
		int getProntuario(){
			return this->prontuario;
		}
		string getNome(){
			return this->nome;
		}
		double getSalario(){
			return this->salario;
		}
		
		void setProntuario(int prontuario){
	 	 	 this->prontuario = prontuario;
		}
		void setNome(string nome){
	 	 	 this->nome = nome;
		}
		void setSalario(double salario){
	 	 	 this->salario =  salario;
		}
};


struct Lista {
	Funcionario funcionario;
	Lista *prox;
};

Lista* init() {
	return NULL;
}

int isEmpty(Lista* lista) {
	return (lista==NULL);
}


bool pesquisarFuncionario(Lista* lista,int prontuario) {
    Lista* aux;
	aux = lista;
	while (aux != NULL && aux->funcionario.getProntuario() != prontuario) {
		aux = aux->prox;
	}	
	if(aux != NULL){
		cout << "\n\n---------------" << endl;
		cout<<"\n\nFuncionário encontrado!\n\n";
		cout <<"\nProntuário:" << aux->funcionario.getProntuario()<< endl;
		cout <<"\nNome:" << aux->funcionario.getNome()<< endl;
		cout <<"\nSalário:" << aux->funcionario.getSalario()<< endl;
		cout << "---------------" << endl;
		return true;
	}
	return false;
}

Lista* cadastrarFuncionario(Lista* lista) {
 	int pronturario;
	
    cout <<"\n\n\n Cadastrar Funcionário: "<< endl;
    cout << "\n\nDigite o prontuário: ";
    cin>>pronturario;
    
    if(pesquisarFuncionario(lista, pronturario)){
		cout <<"\n\nOperação inválida! \nFuncionário com o mesmo prontuário encontrado! Por favor, verifique os dados e tente novamente."<< endl;
		return lista;
   }

		string nome;
		double salario;
		
		cout << "\nDigite o nome do Funcionário: ";
	        cin.ignore(); 
    		getline(cin, nome);
		
	    cout << "\nDigite o salário do Funcionário: ";
	    cin>>salario;
	    
	 	Funcionario f(pronturario, nome, salario);
	    Lista* novo = new Lista();
		novo->funcionario = f;
		novo->prox = lista;
		cout << "\n\nFuncionário Cadastrado com Sucesso!\n ";
		return novo;
  
    
}



Lista* deletarFuncionario(Lista* lista, int prontuario) {	
	
	Lista* aux;
    Lista* ant = NULL;
    
	aux = lista;
	
	while (aux != NULL && aux->funcionario.getProntuario() != prontuario) { 
	    ant = aux;	
		aux = aux->prox;
	}	
	
    if (aux == NULL) {
		cout<< "\n\nFuncionário não encontrado!\n"; 
		return lista;
	}
	
	if (ant == NULL) { // era o primeiro
		lista = aux->prox;
	}
	else { // estava no meio
		ant->prox = aux->prox;
	}
	free(aux);
	cout<< "\n\n Funcionário deletado com Sucesso!\n";
	
	return lista;
}



void listarFuncionarios(Lista* lista) {
    Lista* aux;
	aux = lista;
	int qtd = 1;
	double totalSalarios = 0;
    cout << "\n\n\n---------------" << endl;
	while (aux != NULL) {
		cout <<"\n"<<qtd <<"º Funcionário: " << endl;
		cout <<"\nProntuário:" << aux->funcionario.getProntuario()<< endl;
		cout <<"\nNome:" << aux->funcionario.getNome()<< endl;
		cout <<"\nSalário:" << aux->funcionario.getSalario()<< endl << endl;
        cout << "---------------" << endl;
		totalSalarios += aux->funcionario.getSalario();
		aux = aux->prox;
		qtd++;
		
	}
	cout << "Total de Salários: "<< totalSalarios << endl;
	cout << "---------------" << endl;

}

void limparLista(Lista* lista) {
    Lista* aux;
	aux = lista;
	while (aux != NULL) {
		Lista *ant = aux->prox;
		free(aux);
		aux = ant;
	}	
}


int main(int argc, char** argv)
{
	setlocale(LC_ALL, "");
	Lista* listaFuncionarios = init();
    int opcao;
	int prontuario;
	
    do {
        cout << "\nMenu de Opções:" << endl;
        cout << "0. Sair" << endl;
        cout << "1. Incluir Funcionário" << endl;
        cout << "2. Excluir Funcionário" << endl;
        cout << "3. Pesquisar Funcionário" << endl;
        cout << "4. Listar Funcionários" << endl;
        cout << "\n\nEscolha uma opção: ";
        cin >> opcao;

        switch (opcao) {
            case 0:
                cout << "\nEncerrando o programa..." << endl;
                break;
            case 1:
                listaFuncionarios = cadastrarFuncionario(listaFuncionarios);
                break;
            case 2:
                cout << "\nDigite o prontuário do funcionário a ser excluído: ";
                cin >> prontuario;
                listaFuncionarios = deletarFuncionario(listaFuncionarios, prontuario);
                break;
            case 3:
               
                cout << "\nDigite o prontuário do funcionário a ser pesquisado: ";
                cin >> prontuario;
                if(pesquisarFuncionario(listaFuncionarios, prontuario) == false)
                	cout << "\nFuncinario não cadastrado!\n\n";
                break;
            case 4:
                listarFuncionarios(listaFuncionarios);
                break;
            default:
                cout << "\nOpção inválida! Por favor, escolha uma opção válida." << endl;
                break;
        }
    } while (opcao != 0);

    limparLista(listaFuncionarios); 
    return 0;
}
