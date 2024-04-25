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
		cout<<"\n\nFuncion�rio encontrado!\n\n";
		cout <<"\nProntu�rio:" << aux->funcionario.getProntuario()<< endl;
		cout <<"\nNome:" << aux->funcionario.getNome()<< endl;
		cout <<"\nSal�rio:" << aux->funcionario.getSalario()<< endl;
		cout << "---------------" << endl;
		return true;
	}
	return false;
}

Lista* cadastrarFuncionario(Lista* lista) {
 	int pronturario;
	
    cout <<"\n\n\n Cadastrar Funcion�rio: "<< endl;
    cout << "\n\nDigite o prontu�rio: ";
    cin>>pronturario;
    
    if(pesquisarFuncionario(lista, pronturario)){
		cout <<"\n\nOpera��o inv�lida! \nFuncion�rio com o mesmo prontu�rio encontrado! Por favor, verifique os dados e tente novamente."<< endl;
		return lista;
   }

		string nome;
		double salario;
		
		cout << "\nDigite o nome do Funcion�rio: ";
	    cin>>nome;
		
	    cout << "\nDigite o sal�rio do Funcion�rio: ";
	    cin>>salario;
	    
	 	Funcionario f(pronturario, nome, salario);
	    Lista* novo = new Lista();
		novo->funcionario = f;
		novo->prox = lista;
		cout << "\n\nFuncion�rio Cadastrado com Sucesso!\n ";
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
		cout<< "\n\nFuncion�rio n�o encontrado!\n"; 
		return lista;
	}
	
	if (ant == NULL) { // era o primeiro
		lista = aux->prox;
	}
	else { // estava no meio
		ant->prox = aux->prox;
	}
	free(aux);
	cout<< "\n\n Funcion�rio deletado com Sucesso!\n";
	
	return lista;
}



void listarFuncionarios(Lista* lista) {
    Lista* aux;
	aux = lista;
	int qtd = 1;
	double totalSalarios = 0;
    cout << "\n\n\n---------------" << endl;
	while (aux != NULL) {
		cout <<"\n"<<qtd <<"� Funcion�rio: " << endl;
		cout <<"\nProntu�rio:" << aux->funcionario.getProntuario()<< endl;
		cout <<"\nNome:" << aux->funcionario.getNome()<< endl;
		cout <<"\nSal�rio:" << aux->funcionario.getSalario()<< endl << endl;
        cout << "---------------" << endl;
		totalSalarios += aux->funcionario.getSalario();
		aux = aux->prox;
		qtd++;
		
	}
	cout << "Total de Sal�rios: "<< totalSalarios << endl;
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
        cout << "\nMenu de Op��es:" << endl;
        cout << "0. Sair" << endl;
        cout << "1. Incluir Funcion�rio" << endl;
        cout << "2. Excluir Funcion�rio" << endl;
        cout << "3. Pesquisar Funcion�rio" << endl;
        cout << "4. Listar Funcion�rios" << endl;
        cout << "\n\nEscolha uma op��o: ";
        cin >> opcao;

        switch (opcao) {
            case 0:
                cout << "\nEncerrando o programa..." << endl;
                break;
            case 1:
                listaFuncionarios = cadastrarFuncionario(listaFuncionarios);
                break;
            case 2:
                cout << "\nDigite o prontu�rio do funcion�rio a ser exclu�do: ";
                cin >> prontuario;
                listaFuncionarios = deletarFuncionario(listaFuncionarios, prontuario);
                break;
            case 3:
               
                cout << "\nDigite o prontu�rio do funcion�rio a ser pesquisado: ";
                cin >> prontuario;
                if(pesquisarFuncionario(listaFuncionarios, prontuario) == false)
                	cout << "\nFuncinario n�o cadastrado!\n\n";
                break;
            case 4:
                listarFuncionarios(listaFuncionarios);
                break;
            default:
                cout << "\nOp��o inv�lida! Por favor, escolha uma op��o v�lida." << endl;
                break;
        }
    } while (opcao != 0);

    limparLista(listaFuncionarios); // Free memory allocated for the list
    return 0;
}