#include <iostream>
#include <cstdlib>
#include <ctime>
#include <locale.h>
#include <windows.h>
using namespace std;

struct No {
    int senha;
    No* prox;
};

struct Fila {
    No* ini;
    No* fim;
};

Fila* initFila() {
    Fila* f = new Fila;
    f->ini = NULL;
    f->fim = NULL;
    return f;
}

int isEmpty(Fila* f) {
    return (f->ini == NULL);
}

void enqueue(Fila* f, int senha) {
    No* no = new No;
    no->senha = senha;
    no->prox = NULL;
    if (isEmpty(f)) {
        f->ini = no;
    } else {
        f->fim->prox = no;
    }
    f->fim = no;
}

int dequeue(Fila* f) {
    int senhaRetirada;
    if (isEmpty(f)) {
        senhaRetirada = -1;
    } else {
        No* no = f->ini;
        senhaRetirada = no->senha;
        f->ini = no->prox;
        if (f->ini == NULL) {
            f->fim = NULL;
        }
        delete no;
    }
    return senhaRetirada;
}

void freeFila(Fila* f) {
    No* no = f->ini;
    while (no != NULL) {
        No* temp = no->prox;
        delete no;
        no = temp;
    }
    delete f;
}

int count(Fila* f) {
    int qtde = 0;
    No* no = f->ini;
    while (no != NULL) {
        qtde++;
        no = no->prox;
    }
    return qtde;
}

void print(Fila* f) {
    No* no = f->ini;
    while (no != NULL) {
        cout << no->senha << " ";
        no = no->prox;
    }
    cout << endl;
}

struct Guiche {
    int id;
    Fila* senhasAtendidas;
};

struct ListaGuiche {
    Guiche guiche;
    ListaGuiche* prox;
};

ListaGuiche* initLista() {
    return NULL;
}

int isEmptyLista(ListaGuiche* lista) {
    return (lista == NULL);
}

ListaGuiche* abrirGuiche(ListaGuiche* lista, int id) {
    Guiche g;
    g.id = id;
    g.senhasAtendidas = initFila();

    ListaGuiche* novo = new ListaGuiche;
    novo->guiche = g;
    novo->prox = lista;
    return novo;
}

Guiche* encontrarGuiche(ListaGuiche* lista, int id) {
    ListaGuiche* no = lista;
    while (no != NULL) {
        if (no->guiche.id == id) {
            return &no->guiche;
        }
        no = no->prox;
    }
    return NULL;
}

void listarSenhasAtendidas(Guiche* guiche) {
    cout << "Senhas atendidas pelo guichê " << guiche->id << ": ";
    print(guiche->senhasAtendidas);
}

int main(int argc, char** argv) {
    setlocale(LC_ALL, "");
    Fila* senhasGeradas = initFila();
    ListaGuiche* listaGuiches = initLista();
    int senha;
    int opcao;
    int qtdSenhasAtendidas = 0;
    int numeroGuiche = 1; 

    srand((unsigned)time(NULL));

    do {
        cout << "\nMenu de Opções:" << endl;
        cout << "0. Sair" << endl;
        cout << "1. Gerar Senha" << endl;
        cout << "2. Abrir guichê" << endl;
        cout << "3. Realizar atendimento" << endl;
        cout << "4. Listar senhas atendidas" << endl;
        cout << "Senhas aguardando atendimento: " << count(senhasGeradas) << endl;
        cout << "Guichês abertos: " << numeroGuiche - 1 << endl;
        cin >> opcao;

        switch (opcao) {
        case 0:
            if (!isEmpty(senhasGeradas)) {
                cout << "\nNão foi possível encerrar o programa! Ainda há senhas geradas e não atendidas!\n\n" << endl;
                opcao = -1;
            } else {
                cout << "\nSenhas atendidas: " << qtdSenhasAtendidas << endl;
                cout << "\nEncerrando o programa..." << endl;
            }
            break;
        case 1:
            senha = rand() % 1000; 
            cout << "\n\nSENHA GERADA: " << senha << endl;
            enqueue(senhasGeradas, senha);
            break;
        case 2:
            listaGuiches = abrirGuiche(listaGuiches, numeroGuiche++);
            cout << "\n\nGuichê " << numeroGuiche - 1 << " aberto!\n\n" << endl;
            break;
        case 3: {
            if (!isEmpty(senhasGeradas)) {
                if (!isEmptyLista(listaGuiches)) {
                    cout << "\n\nDigite o número do guichê para realizar o atendimento: ";
                    int idGuiche;
                    cin >> idGuiche;
                    Guiche* guiche = encontrarGuiche(listaGuiches, idGuiche);
                    if (guiche) {
                        senha = dequeue(senhasGeradas);
                        enqueue(guiche->senhasAtendidas, senha);
                        qtdSenhasAtendidas++;
                        cout << "\n\n=================================" << endl;
                        cout << "||          SENHA: " << senha << "        || " << endl << endl;
                        cout << "GUICHÊ: " << idGuiche << endl;
                        cout << "=================================" << endl;
                        Beep(500, 1000);
                    } else {
                        cout << "\nGuichê não encontrado!\n";
                    }
                } else {
                    cout << "\n\nNão há guichês abertos!\n\n";
                }
            } else {
                cout << "\n\nNão há senhas para atendimento!\n\n";
            }
            break;
        }
        case 4: {
            cout << "\n\nDigite o número do guichê: ";
            int idGuiche;
            cin >> idGuiche;
            Guiche* guiche = encontrarGuiche(listaGuiches, idGuiche);
            if (guiche) {
                listarSenhasAtendidas(guiche);
            } else {
                cout << "\nGuichê não encontrado!\n";
            }
            break;
        }
        default:
            cout << "\nOpção inválida! Por favor, escolha uma opção válida." << endl;
            break;
        }
    } while (opcao != 0);

    freeFila(senhasGeradas);
    ListaGuiche* guicheAtual = listaGuiches;
    while (guicheAtual != NULL) {
        freeFila(guicheAtual->guiche.senhasAtendidas);
        ListaGuiche* temp = guicheAtual;
        guicheAtual = guicheAtual->prox;
        delete temp;
    }

    return 0;
}
