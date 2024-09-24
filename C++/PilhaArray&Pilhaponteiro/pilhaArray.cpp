#include <iostream>
#include <locale.h>
using namespace std;

#define MAX 30

struct Pilha {
    int qtde;
    int elementos[MAX];
};

Pilha* init() {
    Pilha *p = new Pilha;
    p->qtde = 0;
    return p;
}

int isEmpty(Pilha *p) {
    return (p->qtde == 0);
}

int count(Pilha *p) {
    return (p->qtde);
}

void freePilha(Pilha *p) {
    free(p);
}

int push(Pilha *p, int v) {
    if (p->qtde < MAX && (p->qtde == 0 || p->elementos[p->qtde - 1] < v)) {
        p->elementos[p->qtde++] = v;
        return 1;
    }
    return 0;
}

int pop(Pilha *p) {
	int podeDesempilhar = (p->qtde > 0);
	int v;
	if (podeDesempilhar) {
		v = p->elementos[p->qtde-1];
		p->qtde--;
	}
	else {
		v = -1;
	}
	return v;
}

void printAndPop(Pilha *p) {
    cout << "Qtde de elementos: " << count(p) << endl;
	for(int i = p->qtde-1; i>=0; --i) {
		cout << p->elementos[i] << endl;
		pop(p);
	}
	cout << "--------------------" << endl;
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
