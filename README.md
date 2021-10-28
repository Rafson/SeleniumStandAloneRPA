# SeleniumStandAloneRPA
  Execução de uma automação Selenium com uma versão específica do Chrome ignorando a versão instalada na máquina

  A ideia é criar uma automação onde você possa levar a sua prórpia versão do Chome, no exemplo é a 83.0.4103.61 e independente da versão do Chome instalado na máquina a versão executada vai ser a carregada pela automação.

  Usado em RPA

#Posso substituir a versão do Chrome?
  - Sim, pode veja o arquivo .Zip na pasa Chrome Raiz do projeto, ele precisa de algumas diretivas
  - Ter o nome da versão
  2 - Ter o arquivo "chrome.exe" no nivel incial do arquivo Zipado
  3 - No App.config você deve mudar a Key "ChromeVersion" para o nome do ZIP sem a extensão ".zip", ex: "83.0.4103.61"
  
O ChomeDriver está setado para 83.* (Onde asterísco é alguma versão que o Nuget Queira)

Se encontrar algum problema ou tiver alguma ideia me chame em rafson@gmail.com ou no Instagram @rrsilvaescritor

Aproveite e dissemine.
