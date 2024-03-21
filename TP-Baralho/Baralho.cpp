#include <iostream>
#include <cstdlib>
#include <ctime>

using namespace std;

#define NUM_CARTAS 52
#define NUM_JOGADORES 4
#define CARTAS_POR_JOGADOR 11




void inicializarBaralho(char **baralho) {
    int index = 0;
    for (int n = 1; n <= 4; ++n) {
        for (int num = 1; num <= 13; ++num) {
            for (int b = 1; b <= 2; ++b) {
                baralho[index] = (char*)malloc(8 * sizeof(char)); 
                sprintf(baralho[index], "%d-%02d-%d", n, num, b);
                index++;
            }
        }
    }
}





void embaralhar(char **baralho) {
    srand(time(NULL));
    for (int i = 0; i < NUM_CARTAS; ++i) {
        int j = rand() % NUM_CARTAS;
        char *temp = baralho[i];
        baralho[i] = baralho[j];
        baralho[j] = temp;
    }
}


void distribuirCartas(char **baralho, char ***mao) {
    for (int j = 0; j < NUM_JOGADORES; ++j) {
        for (int c = 0; c < CARTAS_POR_JOGADOR; ++c) {
            mao[j][c] = baralho[j * CARTAS_POR_JOGADOR + c];
        }
    }
}


void imprimirMaos(char ***mao) {
    for (int j = 0; j < NUM_JOGADORES; ++j) {
        cout << "\nMão do Jogador " << j + 1 << ":" << endl << endl;
        for (int c = 0; c < CARTAS_POR_JOGADOR; ++c) {
            cout << mao[j][c] << endl;
        }
        cout << endl;
    }
}

int main() {
    
 	//setlocale(LC_ALL, "");
 	
    char **baralho = (char**)malloc(NUM_CARTAS * sizeof(char*));
    char ***mao = (char***)malloc(NUM_JOGADORES * sizeof(char**));
    for (int j = 0; j < NUM_JOGADORES; ++j) {
        mao[j] = (char**)malloc(CARTAS_POR_JOGADOR * sizeof(char*));
    }

   
    inicializarBaralho(baralho);
    embaralhar(baralho);

   
    distribuirCartas(baralho, mao);

    
    imprimirMaos(mao);


    return 0;
}
