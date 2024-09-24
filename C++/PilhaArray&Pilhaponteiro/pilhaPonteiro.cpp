
#include <iostream>
#include <locale.h>
using namespace std;



struct No {
    int dado;
	struct No *prox;	
};

struct Pilha {
	No *topo;
};

Pilha* init() {
	Pilha *p = new Pilha;
	p->topo = NULL;
	return p;
}

int isEmpty(Pilha *p) {
	return (p->topo == NULL);
}

int count(Pilha *p) {
	int i = 0;
	No *no;
	no = p->topo;
	while (no != NULL) {
		i++;
		no = no->prox;
	}
	return i;
}


void freePilha(Pilha *p) {
    No *no;
	no = p->topo;
	while (no != NULL) {
		No *aux = no->prox;
		free(no);
		no = aux;
	}	
	free(p);
}

int pop(Pilha *p) {
	int v;
	int podeDesempilhar = (p->topo != NULL);
	if (podeDesempilhar) {
		No *no = p->topo;
		v = no->dado;
		p->topo = no->prox;
		free(no);
	}
	else {
		v = -1;
	}
	return v;
}

void printAndPop(Pilha *p) {
	No *no;
	no = p->topo;
	cout << "Qtde de elementos: " << count(p) << endl;
	while (no != NULL) {
		cout << no->dado << endl;
		no = no->prox;
		pop(p);
	}
	cout << "--------------------" << endl;
}

int push(Pilha *p, int v) {
	if(isEmpty(p) || v > p->topo->dado){
		No *no = new No;
        no->dado = v;
        no->prox = p->topo;
        p->topo = no;
        return 1;
	}
	return 0;
	
}



int main(int argc, char** argv)
{
    setlocale(LC_ALL, "");
    Pilha *pilhaImpar;
    Pilha *pilhaPar;
    pilhaImpar = init();
    pilhaPar = init();
    int valores, i;
    cout << "Digite 30 números inteiros. Garanta que cada número digitado seja maior do que o anterior, mantendo a ordem crescente da digitação" << endl << endl;
    for (i = 0; i < 30; ++i) {
        cout << "Digite o " << (i + 1) << "º valor: ";
        cin >> valores;
        if (valores % 2 == 0) {
            if (!push(pilhaPar, valores)) {
                cout << "Erro ao empilhar!" << endl;
                break;
            }
        } else {
            if (!push(pilhaImpar, valores)) {
                cout << "Erro ao empilhar!" << endl;
                break;
            }
        }
    }

    if (i == 30) {
        cout << "\n\nPilha Impar:" << endl<< endl;
        printAndPop(pilhaImpar);
        cout << "Pilha Par:" << endl<< endl;
        printAndPop(pilhaPar);
    } else {
        cout << "\n\nOcorreu um erro ao empilhar algum valor! Tente de novo."<<endl;
    }

    freePilha(pilhaImpar);
    freePilha(pilhaPar);
    return 0;
}
