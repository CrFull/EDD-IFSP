#include <iostream>
#include <locale.h>
#include <ctime>
#include <cctype>
using namespace std;

class Data
{
	private:
		int dia;
		int mes;
		int ano;
		
    public: 
    	Data(int dia, int mes, int ano) {
			this->dia = dia;
			this->mes = mes;
			this->ano = ano;
		}
    	Data() {
			this->dia = 0;
			this->mes = 0;
			this->ano = 0;
		}
		void setDia(int dia) {
			this->dia = dia;
		}
		void setMes(int mes) {
			this->mes = mes;
		}
		void setAno(int ano) {
			this->ano = ano;
		}
		
		int getDia() {
			return this->dia;
		}
		int getMes() {
			return this->mes;
		}
		int getAno() {
			return this->ano;
		}
		string getData() {
		    string sDia = to_string(this->dia);
		    string sMes = to_string(this->mes);
		    string sAno = to_string(this->ano);
		    
		    return sDia.insert(0, 2-sDia.size(),'0') + "/" +
		           sMes.insert(0, 2-sMes.size(),'0') + "/" +
			       sAno;
        }
        
        Data* dia_seguinte() { 
        	Data *d1 = new Data(this->dia, this->mes, this->ano);
		    int diasNoMes[12] = {31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31};;
			if (d1->ano%4 == 0)
			{
				diasNoMes[1] = 29;
			} 
			d1->dia++;
			if (d1->dia > diasNoMes[d1->mes-1])
			{
				d1->dia = 1;
				d1->mes++;
				if(d1->mes > 12)
				{
					d1->mes = 1;
					d1->ano++;
				}
			}
			return d1;
		}
		
}; // Fim da classe


class Contato{
	private: 
		string email;
		string nome;
		string telefone;
		Data dtnasc;
	public: 
		Contato(string email, string nome, string telefone, Data dtnasc)	{
			this->email = email;
			this->nome = nome;
			this->telefone =  telefone;
			this->dtnasc = dtnasc;
		}
		Contato(){
            this->email = "";
			this->nome = "";
			this->telefone =  "";
			this->dtnasc = Data();
		}
		string getEmail(){
			return this->email;
		}
		string getNome(){
			return this->nome;
		}
		string getTelefone(){
			return this->telefone;
		}
		Data getData(){
			return this->dtnasc;
		}
		void setEmail(string email){
	 	 	 this->email = email;
		}
		void setNome(string nome){
	 	 	 this->nome = nome;
		}
		void setTelefone(string telefone){
	 	 	 this->telefone = telefone;
		}
		void setData(Data dtnasc){
	 	 	 this->dtnasc = dtnasc;
		}
		int idade(){
			time_t t = time(nullptr); 
	        tm* now = localtime(&t); 
	
	        int anoAtual = now->tm_year + 1900; 
	        int mesAtual = now->tm_mon + 1;    
	        int diaAtual = now->tm_mday;        
	
	      
	        int idade = anoAtual - this->dtnasc.getAno();
	        if (mesAtual < dtnasc.getMes() || (mesAtual == dtnasc.getMes() && diaAtual < dtnasc.getDia())) {
	            idade--; 
	        }
	        return idade;
		}
};

string stringToUpper(const string& str) {
    string upperStr = str; 

    
    for (char& c : upperStr) {
        c = toupper(c); 
    }

    return upperStr; 
}

void cadastrarContato(int qtd) {
    for(int i = 0; i<qtd; i++){
	    string email, nome, telefone;
	    int dia, mes, ano;
	
		cout <<"\n\n\n"<< i+1 <<" º Contato";
	    cout << "\n\nDigite o email do contato: ";
	    cin>>email;
	    
	    cout << "Digite o nome do contato: ";
	    cin>>nome;
	
	    cout << "Digite o telefone do contato: ";
	    cin>>telefone;;
	
	    cout << "Digite a data de nascimento do contato (DD MM AAAA): ";
	    cin >> dia >> mes >> ano;
	
	
	    Data dtnasc(dia, mes, ano);
	
	    Contato novoContato(email, nome, telefone, dtnasc);
	
	    cout << "\n\nContato cadastrado com sucesso:\n" << endl;
	    cout <<  stringToUpper(novoContato.getNome())<< endl;
		cout << "Email: " << novoContato.getEmail() << endl;
	    cout << "Telefone: " << novoContato.getTelefone() << endl;
	    cout << "Data de Nascimento: " << novoContato.getData().getDia() << "/" << novoContato.getData().getMes() << "/" << novoContato.getData().getAno() << endl;
	    cout << "Idade: " << novoContato.idade() << " anos" << endl << endl;
	}

}


int main(int argc, char** argv)
{
	setlocale(LC_ALL, "");
	int qtd;
	cout << "Digite a quantidade de Contatos que deseja Cadastrar: ";
	cin>> qtd;
	cadastrarContato(qtd);
	
	return 0;
}