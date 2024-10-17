/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package pesquisaDigital;

/**
 *
 * @author laboratorio
 */


public class Util {
    
    public static void main(String[] args) {
        //String frasePequena = "Turma de pesquisa e ordenação de Isabel Rogia";
        
        //String expressao = "isa";
        
        //System.out.println(Util.contarFrasePequena(frasePequena, expressao));
        
        
        String palavra;
        StringBuffer umaFraseGrande;
        StringBuilder umTextoGigante;
    }
    
    
    public static int contarOcorrencias( String texto, String expressao){
        int ocorrencia = 0;
        String sequencia;
        for(int i = 0; !expressao.equals("" ) && i<= texto.length() -expressao.length() ; i++){
            if(expressao.equalsIgnoreCase(texto.substring(i, i+expressao.length()))){
                ocorrencia++;
                
                //sequencia = texto.substring(i, i+expressao.length());
                //texto = texto.replace(sequencia, sequencia.toUpperCase());
            }
        }
        
        return ocorrencia;
    }
    

}
