#include <iostream>; 
#include <cstdlib>;
#include <locale>
#include <iomanip>

using namespace std;

#define FILEIRAS 15
#define POLTRONAS 40
int** teatro;
int lugares_ocupados = 0;
float faturamento_total = 0.0f;

//João Victor Crivoi Cesar Souza(CB3026027)

void criarTeatro() {
    teatro = (int**)malloc(FILEIRAS * sizeof(int*));
    for (int i = 0; i < FILEIRAS; i++) {
        teatro[i] = (int*)malloc(POLTRONAS * sizeof(int));
        for (int j = 0; j < POLTRONAS; j++) {
            teatro[i][j] = 0;
        }
    }
}

void demolirTeatro() {
    for (int i = 0; i < FILEIRAS; i++) {
        free(teatro[i]);
    }
    free(teatro);
}

void mapaDeOcupacao() {
    cout << "\n\nMapa de ocupação:\n" << endl;
    
    
    for (int i = 0; i < FILEIRAS; i++) {
        for (int j = 0; j < POLTRONAS; j++) {
        	//isso aqui é muito legal
            cout  << (teatro[i][j] == 0 ? '.' : '#')  << " ";
        }
        cout << endl ;
    }
    cout << endl;
}

void reservarPoltrona() {
    int fileira, poltrona;
    cout << "\n\nDigite o número da fileira (1 a 15): ";
    cin >> fileira;
    if (fileira < 1 || fileira > FILEIRAS){
		 cout << "\nFileira inválida!" << endl;
        system("pause");
        return;
	}
    cout << "Digite o número da poltrona (1 a 40): ";
    cin >> poltrona;

    if (poltrona < 1 || poltrona > POLTRONAS) {
        cout << "\nPoltrona inválida!" << endl;
        system("pause");
        return;
    }

    if (teatro[fileira - 1][poltrona - 1] == 0) {
        float valor;
        if (fileira <= 5)
            valor = 50.0f;
        else if (fileira <= 10)
            valor = 30.0f;
        else
            valor = 15.0f;

        cout << "\n\nPoltrona reservada com sucesso!\n\n" << endl;
        teatro[fileira - 1][poltrona - 1] = 1;
        lugares_ocupados++;
        faturamento_total += valor;
        system("pause");
    } else {
        cout << "\n\nPoltrona ocupada.\n\n" << endl;
        system("pause");
    }
}

void exibirFaturamento() {
    cout << "\n\nQuantidade de lugares ocupados: " << lugares_ocupados << endl;
    cout << "Valor da bilheteria: R$ " << faturamento_total  << endl << endl;
    system("pause");
}


int main(int argc, char** argv)
{	
	setlocale(LC_ALL, "Portuguese");
	
	bool finalizar = false;
	int opcao;
	
	criarTeatro();
	while(finalizar==false){
		cout << "\nOpções:" << endl << endl;
        cout << "0. Finalizar" << endl;
        cout << "1. Reservar poltrona" << endl;
        cout << "2. Mapa de ocupação" << endl;
        cout << "3. Faturamento" << endl;
        cout << "\nDigite o número da opção desejada:\n";
        cin >> opcao;

        switch (opcao) {
            case 0:
                demolirTeatro();
                finalizar = true;
            case 1:
                reservarPoltrona();
                system("cls");
                break;
            case 2:
                mapaDeOcupacao();
                break;
            case 3:
                exibirFaturamento();
                system("cls");
                break;
            default:
                cout << "\nDigite um opção válida!\n" << endl;
                system("cls");
                break;
        }    
	}
	
	
	return 0;
}