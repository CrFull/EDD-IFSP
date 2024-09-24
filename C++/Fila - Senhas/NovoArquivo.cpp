#include <iostream>
#include <cstdlib>
#include <time.h>
#include <locale.h>
#include <windows.h>
using namespace std;

struct No{
	int senha;
	No *prox;
};

struct Fila{
	   No *ini;
	   No *fim;	
};

Fila* init(){
	Fila *f = new Fila;
	f->ini = NULL;
	f->fim = NULL;
	return f;
} 

int isEmpty(Fila *f) {
	return (f->ini == NULL);
}

void enqueue(Fila *f, int senha) {
	No *no = new No;
	no->senha = senha;
	no->prox = NULL;
	if (isEmpty(f)) {
		f->ini = no;
	}
	else {
		f->fim->prox = no;
	}
	f->fim = no;
}

int dequeue(Fila *f) {
	int senhaRetirada;
	if (isEmpty(f)) {
		senhaRetirada = -1;
	}
	else {
		No *no = f->ini;
		senhaRetirada = no->senha;
		f->ini = no->prox;
		if (f->ini == NULL) {
			f->fim = NULL;
		}
	    free(no);	
	}
	return senhaRetirada;
}

void freeFila(Fila *f) {
	No *no = f->ini;
	while (no != NULL) {
		No *temp = no->prox;
		free(no);
		no = temp;
	}
	free(f);
}

int count(Fila *f) {
	int qtde = 0;
	No *no;
	no = f->ini;
	while (no != NULL) {
		qtde++;
		no = no->prox;
	}
	return qtde;
}

void print(Fila *f) {
	No *no;
	no = f->ini;
	while (no != NULL) {
		cout << no->senha << endl;
		no = no->prox;
	}
}


int main(int argc, char** argv)
{
	setlocale(LC_ALL, "");
	Fila* senhasGeradas = init();
	Fila* senhasAtendidas = init();
	int senha;
	int opcao;
	int qtdSenhasAtendidas = 0;
	srand((unsigned) time(NULL));
	
    do {
        cout << "\nMenu de Opções:" << endl;
        cout << "0. Sair" << endl;
        cout << "1. Gerar Senha" << endl;
        cout << "2. Realizar atendimento\n" << endl;
        cin >> opcao;

        switch (opcao) {
            case 0:
            	if(isEmpty(senhasGeradas)==false){
					opcao = -1;
					cout << "\n\nNão foi possível encerrar o programa! Há ainda senhas geradas e não atendidas!\n\n" << endl;
					break;
				}
   		        cout << "\nSenhas atendidas: " << qtdSenhasAtendidas << endl;
                cout << "\nEncerrando o programa..." << endl;
                break;
            case 1:
            	senha = rand();
                cout << "\n\n SENHA GERADA: " << senha  << endl;
                enqueue(senhasGeradas,senha);
                break;
            
            case 2:
            	if(isEmpty(senhasGeradas)==false){
	            	senha = dequeue(senhasGeradas);
	                enqueue(senhasAtendidas,senha);
	                qtdSenhasAtendidas++;
	                cout<<"\n\n================================="<<endl;
	                cout<< "||          SENHA: "<< senha<<"        || "<<endl<<endl;
	                senha = rand()%10;
	                cout<< "CAIXA: "<< senha<<endl;
	                cout<<"\n\n================================="<<endl;
					cout<< "SENHAS AGUARDANDO ATENDIMENTO: "<<endl;
					print(senhasGeradas);
					cout<<"================================="<<endl;
					cout<<"\n\n"<<endl;	
					Beep (500, 1000);	
				}else
					cout<<"\n\nNão há senhas para atendimento!\n\n";
				
                break;
            
		            
            default:
                cout << "\nOpção inválida! Por favor, escolha uma opção válida." << endl;
                break;
        }
    } while (opcao != 0);
    freeFila(senhasGeradas);
    freeFila(senhasAtendidas);	
	return 0;
}
