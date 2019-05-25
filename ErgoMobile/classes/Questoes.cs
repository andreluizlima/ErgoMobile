using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace ErgoMobile.classes
{
    class Questoes
    {
        private List<String> presteza;
        private List<String> agrLocalizacao;
        private List<String> agrFormato;
        private List<String> feedback;
        private List<String> legibilidade;
        private List<String> concisao;
        private List<String> acoesMinimas;
        private List<String> densidadeInformacional;
        private List<String> acoesExplicitas;
        private List<String> controleUsuario;
        private List<String> flexibilidade;
        private List<String> expUsuario;
        private List<String> protecaoContraErros;
        private List<String> msgsErro;
        private List<String> correcaoErros;
        private List<String> consistencia;
        private List<String> significados;
        private List<String> compatibilidade;

        public List<string> Presteza { get => presteza; set => presteza = value; }
        public List<string> AgrLocalizacao { get => agrLocalizacao; set => agrLocalizacao = value; }
        public List<string> AgrFormato { get => agrFormato; set => agrFormato = value; }
        public List<string> Feedback { get => feedback; set => feedback = value; }
        public List<string> Legibilidade { get => legibilidade; set => legibilidade = value; }
        public List<string> Concisao { get => concisao; set => concisao = value; }
        public List<string> AcoesMinimas { get => acoesMinimas; set => acoesMinimas = value; }
        public List<string> DensidadeInformacional { get => densidadeInformacional; set => densidadeInformacional = value; }
        public List<string> AcoesExplicitas { get => acoesExplicitas; set => acoesExplicitas = value; }
        public List<string> ControleUsuario { get => controleUsuario; set => controleUsuario = value; }
        public List<string> Flexibilidade { get => flexibilidade; set => flexibilidade = value; }
        public List<string> ExpUsuario { get => expUsuario; set => expUsuario = value; }
        public List<string> ProtecaoContraErros { get => protecaoContraErros; set => protecaoContraErros = value; }
        public List<string> MsgsErro { get => msgsErro; set => msgsErro = value; }
        public List<string> CorrecaoErros { get => correcaoErros; set => correcaoErros = value; }
        public List<string> Consistencia { get => consistencia; set => consistencia = value; }
        public List<string> Significados { get => significados; set => significados = value; }
        public List<string> Compatibilidade { get => compatibilidade; set => compatibilidade = value; }


        public Questoes(string  lang)
        {
            if (lang=="en")
            {
                ///
                ///
                ///
                //              INGLES
                ///
                ///
                ///

                    Presteza = new List<string>
                {
                    "1 - Are screen titles, windows, and dialog boxes on top, centered or justified on the left?",
                    "2 - Are all data fields and counters labeled?",
                    "3 - If the data to be entered has a particular format, is this format described on the screen?",
                    "4 - Are the units for the input or presentation of metric or financial data described on the screen?",
                    "5 - Do the field labels contain a specific element, for example \": \"as an invitation to data entries?",

                    "6 - If the data to be entered has acceptable values, are these values ​​described on the screen?",
                    "7 - Long lists show continuation indicators, number of items and pages?",
                    "8 - Do the tables have headings for consistent and distinguishable rows and columns of the data presented?",
                    "9 - Do the graphics have a general title and labels for their axes?",
                    "10 - Do the buttons that command the presentation of dialog boxes display the \" ... \"sign on their labels as an indicator of continuity and dialogue?",

                    "11 - Do the menu pages have titles, headers or invitations to the entry?",
                    "12 - Do the menu options that lead to other menu panels display the \"> \"sign as an indicator of this fact?",
                    "13 - Do you find the information you need for your actions?",
                    "14 - In the error message boxes, the command button \" HELP \"is always present?",

                    "15 - Is the response to a user help request structured in the context of the task and the current transaction?",
                    "16 - Is it possible for the user to get the list of basic language commands?",
                    "17 - In the occurrence of errors, can the user access all the information necessary to diagnose and solve the problem?" };


                    //AGRUPAMENTO POR LOCALIZAÇÃO
                    AgrLocalizacao = new List<string>
                {
                    "1 - Is the presentation space diagrammed into small functional zones?",
                    "2 - Does the layout of the interaction objects of a dialog box follow a logical order?",
                    "3 - In the data groupings, the items are organized spatially according to a logical criterion?",
                    "4 - Are the menu option hotkey codes located to the right of the option name?",
                    "5 - In the selection lists, are the options arranged in any logical order?",
                    "6 - Are the menu panels formed from a logic of grouping options?",
                    "7 - Within a menu panel, are mutually exclusive or interdependent options grouped and separated from each other?",
                    "8 - Are the options within a menu panel sorted by logical criteria?",
                    "9 - Does the default menu option setting follow any criteria?",
                    "10 - Are the command button groups arranged in a column and to the right, or in line and below the objects to which they are associated?",
                    "11 - Is the command button selected by default set to the highest position, whether the buttons are set vertically or leftmost if the buttons are horizontally set?"
                };

                    //AGRUPAMENTO POR FORMATO
                    AgrFormato = new List<string>
                {
                    "1 - Are the controls and controls visually different from the information displayed on the screens?",
                    "2 - Are visual codes used to associate different categories of scattered distributed data across screens?",
                    "3 - The different types of elements of a query screen (data, commands and instructions) are visually distinct from one another?",
                    "4 - Are the labels visually different from the data to which they are associated?",
                    "5 - Are the headings of a table differentiated by using different colors, larger letters or underlined?",
                    "6 - In abnormal situations, critical data and requiring immediate attention are differentiated through the use of bright colors such as red or pink?",
                    "7 - Are sound signals used to alert users to a visual presentation?",
                    "8 - In the presentation of texts, the style resources, such as italics, bold, underlined or different sources are used to highlight important words or notions?",
                    "9 - Are the items selected for change, update or activation highlighted by others?",
                    "10 - In alarm situations and in high-density information screens, is the visual intermittent feature used to highlight data and information?",
                    "11 - Are the required fields differentiated from the optional fields visually clear?",
                    "12 - In the message boxes, the button selected by default has a visual presentation sufficiently different from the others?",
                    "13 - In situations where the user's special attention is required, are alert and warning messages presented differently?",
                    "14 - Is the shape of the mouse cursor different from that of any other item displayed?",
                    "15 - Are the shapes of cursors (two or more) presented simultaneously sufficiently distinct from one another?",
                    "16 - Are the grouping boxes used to highlight a group of related data?",
                    "17 - When you present options that are not currently available, does the system show them differently visually?"
                };

                    //FEEDBACK
                    Feedback = new List<string>
                {
                    "1 - Does the system provide feedback for all user actions?",
                    "2 - When, during data entry, the system becomes unavailable to the user, due to some long processing, the user is warned of this state of the system and the time of this unavailability?",
                    "3 - Does the system provide print status information?",
                    "4 - Are items selected from a list highlighted visually immediately?",
                    "5 - Does the cursor image provide dynamic and contextual feedback on direct manipulation?",
                    "6 - Does the system provide the user with timely processing information?",
                    "7 - Does the system display a message stating the success or failure of time-consuming processing?",
                    "8 - Does the system provide immediate and continuous feedback from direct manipulations?",
                    "9 - Does the system define the focus of actions for newly created or newly opened objects?",
                    "10 - Does the system provide feedback on object attribute changes?",
                    "11 - Any change in the current situation of control objects is presented visually clearly to the user?",
                    "12 - Does the system provide a history of commands entered by the user during a work session?"
                };

                    //LEGIBILIDADE
                    Legibilidade = new List<string>
                {
                    "1 - Are free areas used to separate logical groups instead of having them all on one side of screen, box or window?",
                    "2 - Are the groups of control and presentation objects that make up dialog boxes and other composite objects aligned vertically and horizontally?",
                    "3 - Are vertically organized field labels very different in size from right-justified?",
                    "4 - The minimum width of the text displays is 50 characters?",
                    "5 - Is the minimum height of the text counters 4 lines?",
                    "6 - Are the text paragraphs separated by at least one blank line?",
                    "7 - Is the use of uppercase texts avoided?",
                    "8 - Is the use of bold is minimized?",
                    "9 - Is Underlining Used Minimized?",
                    "10 - In the tables, are blank lines used to separate groups?",
                    "11 - Are alphabetical data lists justified on the left?",
                    "12 - Do lists containing decimal numbers have comma alignment?",
                    "13 - Are the lines used for framing and segmenting menus (separators, delimiters, etc.) simple?",
                    "14 - Are the menu board edges sufficiently separated from the options texts so as not to impair their readability?",
                    "15 - Is the use of abbreviations minimized in the menus?",
                    "16 - Are the option names only with the initial capitalization?",
                    "17 - The numbers that indicate the menu options are right-aligned?",
                    "18 - When alphabetic enumeration is used, are the letters for selection left-aligned?",
                    "19 - Are the horizontal menu bar options separated by at least 2 white characters?",
                    "20 - Field labels begin with a capital letter, and the remaining letters are lowercase?",
                    "21 - Are long data items partitioned into shorter groups, both in entries and in presentations?",
                    "22 - Do the alphanumeric system codes separately group letters and numbers?",
                    "23 - Are the icons readable?",
                    "24 - Does the system use (textual) labels when there may be ambiguity of icons?",
                    "25 - Is the encoded information with the reverse video readable?",
                    "26 - Is the use of reverse video restricted to the indication of selection feedback?",
                    "27 - Are the data to be read displayed continuously, that is, not flashing?"
                };
                // CONCISAO
                Concisao = new List<string>()
                {
                    "1 - Does the system provide defaults to speed up data entry?",
                    "2 - Is the alphanumeric identification of the windows short enough to be easily recalled?",
                    "3 - Are the menu option names concise?",
                    "4 - Are icons economical from the point of view of screen space?",
                    "5 - Are the denominations brief?",
                    "6 - Are the abbreviations short?",
                    "7 - The arbitrary codes that the user must memorize are always smaller than 4 or 5 characters?",
                    "8 - Are the labels concise?",
                    "9 - Are alphanumeric codes not significant to the user and that must be entered in the system are smaller than 7 characters?",
                    "10 - In alphanumeric data entry, does the system consider uppercase and lowercase letters as equivalent?",
                    "11 - In numeric data entry, is the user freed from filling the unnecessary decimal point?",
                    "12 - In numeric input, is the user freed from filling in unnecessary fractional zeros?",
                    "13 - When entering metric or financial values, is the user released from filling the unit of measurement?",
                    "14 - Is it permissible for the user to reuse the values ​​defined for previous entries, and can even change them?"
                };
                // AÇOES MINIMAS
                AcoesMinimas = new List<string>
                {
                     "1 - In data entry form does the system position the cursor at the beginning of the first input field?",
                     "2 - When performing the main actions in a dialog box, does the user have minimized cursor movements through proper ordering of objects?",
                     "3 - Does the user have a simple and quick way (TAB key for example) to navigate between the fields of a form?",
                     "4 - Do the command button groups always have a button set as default?",
                     "5 - Is the menu structure designed to narrow down the steps required for selection?"
                };
                //  DENSIDADE INFORMACIONAL
                DensidadeInformacional = new List<string>
                {
                    "1 - Is the informational density of windows reduced?",
                    "2 - Do the screens present only the data and information necessary and indispensable for the user in his task?",
                    "3 - In the encoded data input, the codes only present the necessary data are present on the screen in a distinguishable way?",
                    "4 - Does the system minimize the user's need to remember exact data from one screen to another?",
                    "5 - In reading a window, the user has their eye movements minimized by distributing the main objects along the lines of a \" Z \"?",
                    "6 - Does the system avoid presenting a large number of windows that can de-center or overload the user memory?",
                    "7 - In the manipulation of the data presented by the system, the user is freed from the translation of units?",
                    "8 - Do the selection and combination lists have a height corresponding to a maximum of nine lines?",
                    "9 - Do the menu panels only show the required options as active?"
                };
                //  ACOES EXPLICITAS
                AcoesExplicitas = new List<string>
                {
                     "1 - Does the system postpone processing until user input actions have been completed?",
                     "2 - During the selection of a menu option does the system allow the separation between indication and execution of the option?",
                     "3 - To initiate data processing, does the system always require the user to explicitly perform \" ENTER \"?",
                     "4 - Is it always the user who commands navigation between fields on a form?"
                };
                //  CONTROLE DE USUARIO
                ControleUsuario = new List<string>
                {
                     "1 - Can the user terminate a repetitive sequential dialog at any time?",
                     "2 - Can the user interrupt and resume a sequential dialog at any time?",
                     "3 - Can the user restart a sequential dialog at any time?",
                     "4 - During the blocking periods of the input devices, does the system provide the user with an option to interrupt the process that caused the blocking?"
                };
                // FLEXIBILIDADE
                Flexibilidade = new List<string>
                {
                     "1 - Do users have the ability to modify or delete irrelevant items from windows?",
                     "2 - Is the user allowed to customize the dialog by defining macros?",
                     "3 - Is the user allowed to change and customize default values?"
                };
                //EXPERIENCIA DE USUARIO
                ExpUsuario = new List<string>
                {
                     "1 - If it is a large public system, does it offer varied ways of presenting the same information to different types of users?",
                     "2 - Are the dialog styles compatible with user skills, allowing step-by-step actions for beginners and more complex command input by experienced users?",
                     "3 - Can the user move from one part of the menu structure to another quickly?",
                     "4 - Does the system provide keyboard equivalents for the selection and execution of menu options, besides the pointing device (mouse, ...)?",
                     "5 - Is the system able to recognize a set of synonyms for the basic terms defined in the command language, in order to adapt to new or occasional users?",
                     "6 - Can the experienced user type several commands before a confirmation?"
                };
                //PROTECAO CONTRA ERROS
                ProtecaoContraErros = new List<string>
                {
                     "1 - Does the system provide adequate separation between selectable areas of a menu panel in order to minimize accidental activations?",
                     "2 - In all destructive action, do the buttons selected by default cancel this action?",
                     "3 - Are numeric fields for long data entry subdivided into smaller groups and punctuated with spaces, commas, hyphens, or bars?",
                     "4 - At the end of a working session does the system report the risk of data loss?",
                     "5 - Does the system emit beeps when data entry problems occur?",
                     "6 - Are the Dangerous Function keys grouped and/or separated from the others on the keyboard?",
                     "7 - Does the system require (double) confirmation of actions that may lead to data loss and/or catastrophic results?"
                };
                //MENSAGENS DE ERRO
                MsgsErro = new List<string>
                {
                    "1 - Do the error messages help to solve the user problem by accurately providing the location and the specific or probable cause of the error, as well as the actions that the user could take to correct it?",
                    "2 - Are the error messages neutral and polished?",
                    "3 - Are the sentences of error messages short and constructed from short, meaningful words and common usage?",
                    "4 - Are the error messages exempt from abbreviations and/or codes generated by the operating system?",
                    "5 - Can the user choose the level of detail of the error messages according to their level of knowledge?",
                    "6 - Is the main information of an error message at the beginning of the message?",
                    "7 - When necessary, what information should the user save to be located in the final part of the error message?",
                    "8 - In normal situations are the error messages written in uppercase/lowercase?",
                    "9 - Do the error messages have their content modified when in the immediate repetition of the same error by the same user?"
                };
                // CORREÇAO DE ERROS
                CorrecaoErros = new List<string>
                {
                     "1 - Can any user action be reversed through the UNDO option?",
                     "2 - Using the REJECT option, can the regression of the dialog also be undone?",
                     "3 - Are the commands for UNDERSTANDING and REFURBING the dialog different?",
                     "4 - Does the system recognize and through a user confirmation, execute the most frequent commands even with misspellings?",
                     "5 - After a typo of a command or data, the user has the possibility to correct only the part of the data or the command that is wrong?"
                };
                //CONSISTENCIA
                Consistencia = new List<string>
                {
                    "1 - Are the boxes, screens or windows unique?",
                    "2 - The organization in terms of the location of the various characteristics of the windows is kept consistent from one screen to another?",
                    "3 - Is the initial position of the cursor kept consistent across all forms presentations?",
                    "4 - Does the same function key switch the same option from one screen to another?",
                    "5 - Are the icons different from each other and always have the same meaning from one screen to another?",
                    "6 - Is the data location kept consistent from one screen to another?",
                    "7 - Are the data presentation formats kept consistent from one screen to another?",
                    "8 - Are the labels in the same position relative to the associated fields?",
                    "9 - The symbol for invitation to data entry is standardized (for example \":\")?",
                    "10 - Are the command entry areas in the same position from one screen to another?",
                    "11 - Are the meanings of the color codes followed consistently?"
                };
                //SIGNIFICADOS
                Significados = new List<string>
                {
                    "1 - Do the denominations of the titles agree with what they represent?",
                    "2 - Are the menu page titles explanatory, reflecting the nature of the choice to be made?",
                    "3 - Are the titles of the menu pages different from each other?",
                    "4 - Are the menu page titles combinable or composable?",
                    "5 - Are the denominations of the menu options familiar to the user?",
                    "6 - Is the vocabulary used in the labels, invitations and orientation messages familiar to the user, avoiding difficult words?",
                    "7 - Is the vocabulary used in labels, invitations and orientation messages task-oriented, using terms and technical jargon normally employed in the task?",
                    "8 - Are the column headers significant and distinct?",
                    "9 - Does the system adopt codes that are meaningful or familiar to users?",
                    "10 - Are the abbreviations significant?",
                    "11 - Are the abbreviations easily distinguishable from each other, avoiding confusion generated by similarity?",
                    "12 - Is the flashing (flashing) used sparingly and only to attract attention to alarms, warnings, or critical messages?"
                };
                //COMPATIBILIDADE
                Compatibilidade = new List<string>
                {
                    "1 - Are the screens compatible with the environment standard?",
                    "2 - Is the image of the form on the terminal screen similar to the paper entry form?",
                    "3 - Does the system propose a modal dialog box when the application must have all the data before proceeding or when the user has to answer an urgent question?",
                    "4 - Do the system dialogs have a validation button, a cancel button and, if possible, a help button?",
                    "5 - Are the usual meanings of colors respected in the defined color codes?",
                    "6 - Are color coding options limited in number?",
                    "7 - Does the color coded information have additional redundant encoding?",
                    "8 - Is the flashing rate for flashing elements between 2 and 5 Hz (2 to 5 flashes per second)?",
                    "9 - Is the sound presentation compatible with ambient noise?",
                    "10 - Are the messages always affirmative and in the active voice?",
                    "11 - When a sentence describes a sequence of events, does the order of words in the sentence correspond to the temporal sequence of events?",
                    "12 - Are illustrations and animations used to complete the explanations of the text?",
                    "13 - Does the system follow user conventions for standardized data?",
                    "14 - Does the system use units of measure familiar to the user?",
                    "15 - Changing numerical data are presented analogously?",
                    "16 - Numerical data that demands reading accuracy are presented digitally?",
                    "17 - Are the items numbered with numbers, not with letters?",
                    "18 - Do numeric menu option identifiers start at \" 1 \", not \" 0 \"?",
                    "19 - Do the axes of a graph have numerical scales starting at zero, with standard intervals, growing from left to right and top to bottom?",
                    "20 - Are the items in a group of radio buttons mutually exclusive?",
                    "21 - Do items in a group of assignment boxes allow for independent choices?"
                };

                //////////////////////////////////////////////////////////////////////////////////////////////////////
                //////////////////////////////////////////////////////////////////////////////////////////////////////
                //////////////////////////////////////////////////////////////////////////////////////////////////////
                //////////////////////////////////////////////////////////////////////////////////////////////////////
                //////////////////////////////////////////////////////////////////////////////////////////////////////
                //////////////////////////////////////////////////////////////////////////////////////////////////////
                //////////////////////////////////////////////////////////////////////////////////////////////////////
                //////////////////////////////////////////////////////////////////////////////////////////////////////
                //////////////////////////////////////////////////////////////////////////////////////////////////////
                //////////////////////////////////////////////////////////////////////////////////////////////////////
                //////////////////////////////////////////////////////////////////////////////////////////////////////
                //////////////////////////////////////////////////////////////////////////////////////////////////////
                //////////////////////////////////////////////////////////////////////////////////////////////////////
                //////////////////////////////////////////////////////////////////////////////////////////////////////
                //////////////////////////////////////////////////////////////////////////////////////////////////////
                //////////////////////////////////////////////////////////////////////////////////////////////////////
                //////////////////////////////////////////////////////////////////////////////////////////////////////
                //////////////////////////////////////////////////////////////////////////////////////////////////////
                //////////////////////////////////////////////////////////////////////////////////////////////////////
                //////////////////////////////////////////////////////////////////////////////////////////////////////
                //////////////////////////////////////////////////////////////////////////////////////////////////////
                //////////////////////////////////////////////////////////////////////////////////////////////////////
                //////////////////////////////////////////////////////////////////////////////////////////////////////
                //////////////////////////////////////////////////////////////////////////////////////////////////////
                //////////////////////////////////////////////////////////////////////////////////////////////////////
                //////////////////////////////////////////////////////////////////////////////////////////////////////
                //////////////////////////////////////////////////////////////////////////////////////////////////////
                //////////////////////////////////////////////////////////////////////////////////////////////////////
                //////////////////////////////////////////////////////////////////////////////////////////////////////
                //////////////////////////////////////////////////////////////////////////////////////////////////////
                //////////////////////////////////////////////////////////////////////////////////////////////////////
                //////////////////////////////////////////////////////////////////////////////////////////////////////
                //////////////////////////////////////////////////////////////////////////////////////////////////////
                //////////////////////////////////////////////////////////////////////////////////////////////////////
                //////////////////////////////////////////////////////////////////////////////////////////////////////
                //////////////////////////////////////////////////////////////////////////////////////////////////////
                //////////////////////////////////////////////////////////////////////////////////////////////////////
            }
            else if (lang=="pt")
            {
                ///
                ///
                ///
                //          PORTUGUESE
                ///
                ///
                ///
                    Presteza = new List<string>
                {
                    "1 - Os títulos de telas, janelas e caixas de diálogo estão no alto, centrados ou justificados à esquerda?",
                    "2 - Todos os campos e mostradores de dados possuem rótulos identificativos?",
                    "3 - Caso o dado a entrar possua um formato particular, esse formato encontra-se descrito na tela?",
                    "4 - As unidades para a entrada ou apresentação de dados métricos ou financeiros encontram-se descritas na tela?",
                    "5 - Os rótulos dos campos contêm um elemento específico, por exemplo \":\", como convite às entradas de dados?",
                    "6 - Caso o dado a entrar possua valores aceitáveis esses valores encontram-se descritos na tela?",
                    "7 - Listas longas apresentam indicadores de continuação, d e quantidade de itens e de páginas?",
                    "8 - As tabelas apresentam cabeçalhos para linhas e colunas consistentes e distinguíveis dos dados apresentados?",
                    "9 - Os gráficos possuem um título geral e rótulos para seus eixos?",
                    "10 - Os botões que comandam a apresentação de caixas de diálogo apresentam em seus rótulos o sinal \"...\" como indicador da continuidad e do diálogo?",
                    "11 - As páginas de menus possuem títulos, cabeçalhos ou convites à entrada?",
                    "12 - As opções de menu que levam a outros painéis de menu apresentam o sinal \" > \" como indicador desse fato?",
                    "13 - O usuário encontra disponíveis as informações necessárias para suas ações?",
                    "14 - Nas caixas de mensagens de erro, o botão de comando \"AJUDA\" está sempre presente?",
                    "15 - A resposta para uma solicitação de ajuda do usuário está estruturada no contexto da tarefa e da transação corrente?",
                    "16 - Existe a possibilidade do usuário obter a lista de comandos básicos da linguagem?",
                    "17 - Na ocorrência de erros, o usuário pode acessar todas as informações necessárias ao diagnóstico e à solução do problema?"
                };


                    //AGRUPAMENTO POR LOCALIZAÇÃO
                    AgrLocalizacao = new List<string>
                {
                    "1 - O espaço de apresentação está diagramado em pequenas zonas funcionais?",
                    "2 - A disposição dos objetos de interação de uma caixa de dialogo segue uma ordem lógica?",
                    "3 - Nos agrupamentos de dados, os itens estão organizados espacialmente segundo um critério lógico?",
                    "4 - Os códigos das teclas aceleradoras de opções de menu estão localizados à direita do nome da opção?",
                    "5 - Nas listas de seleção, as opções estão organizadas segundo alguma ordem lógica?",
                    "6 - Os paineis de menus são formados a partir de um critério lógico de agrupamento de opções?",
                    "7 - Dentro de um painel de menu, as opções mutuamente exclusivas ou interdependentes estão agrupadas e separadas das demais?",
                    "8 - As opções dentro de um painel de menu estão ordenadas segundo algum critério lógico?",
                    "9 - A definição da opção de menu selecionada por default segue algum critério?",
                    "10 - Os grupos de botões de comando estão dispostos em coluna e à direita, ou em linha e abaixo dos objetos aos quais estão associados?",
                    "11 - O botão de comando selecionado por default está na posição mais alta, se os botões estão dispostos verticalmente, ou na mais à esquerda, se os botões estão dispostos horizontalmente?"
                };

                    //AGRUPAMENTO POR FORMATO
                    AgrFormato = new List<string>
                {
                    "1 - Os controles e comandos encontram-se visualmente diferenciados das informações apresentadas nas telas?",
                    "2 - Códigos visuais são empregados para associar diferentes categorias de dados distribuídos de forma dispersa nas telas?",
                    "3 - Os diferentes tipos de elementos de uma tela de consulta (dados, comandos e instruções) são visualmente distintos uns dos outros?",
                    "4 - Os rótulos são visualmente diferentes dos dados aos quais estão associados?",
                    "5 - Os cabeçalhos de uma tabela estão diferenciados através do emprego de cores diferentes, letras maiores ou sublinhadas?",
                    "6 - Em situações anormais, os dados críticos e que requeiram atenção imediata são diferenciados através do uso de cores brilhantes como por exemplo, o vermelho ou o rosa?",
                    "7 - Sinais sonoros são empregados para alertar os usuários em relação a uma apresentação visual?",
                    "8 - Na apresentação de textos, os recursos de estilo, como itálico, negrito, sublinhado ou diferentes fontes são empregados para salientar palavras ou noções importantes?",
                    "9 - Os itens selecionados para alteração, atualização ou acionamento estão destacados dos outros?",
                    "10 - Nas situações de alarme e nas telas de alta densidade de informação, o recurso de intermitência visual é empregado para salientar dados e informações?",
                    "11 - Os campos obrigatórios são diferenciados dos campos opcionais de forma visualmente clara?",
                    "12 - Nas caixas de mensagens, o botão selecionado por default tem uma apresentação visual suficientemente distinta dos outros?",
                    "13 - Em situações em que se exija atenção especial do usuário, as mensagens de alerta e de aviso são apresentadas de maneira distinta?",
                    "14 - A forma do cursor do mouse é diferente da de qualquer outro item apresentado?",
                    "15 - As formas de cursores (dois ou mais) apresentados simultaneamente são suficientemente distintas umas das outras?",
                    "16 - As caixas de agrupamento são empregadas para realçar um grupo de dados relacionados?",
                    "17 - Quando apresenta opções não disponíveis no momento, o sistema as mostra de forma diferenciada visualmente?"
                };

                    //FEEDBACK
                    Feedback = new List<string>
                {
                    "1 - O sistema fornece feedback para todas as ações do usuário?",
                    "2 - Quando, durante a entrada de dados, o sistema torna-se indisponível ao usuário, devido a algum processamento longo, o usuário é avisado desse estado do sistema e do tempo dessa indisponibilidade?",
                    "3 - O sistema fornece informações sobre o estado das impressões?",
                    "4 - Os itens selecionados de uma lista são realçados visualmente de imediato?",
                    "5 - A imagem do cursor fornece feedback dinâmico e contextual sobre a manipulação direta?",
                    "6 - O sistema fornece ao usuário informações sobre o tempo de processamentos demorados?",
                    "7 - O sistema apresenta uma mensagem informando sobre o sucesso ou fracasso de um processamento demorado?",
                    "8 - O sistema fornece feedback imediato e contínuo das manipulações diretas?",
                    "9 - O sistema define o foco das ações para os objetos recém criados ou recém abertos?",
                    "10 - O sistema fornece feedback sobre as mudanças de atributos dos objetos?",
                    "11 - Qualquer mudança na situação atual de objetos de controle é apresentada visualmente de modo claro ao usuário?",
                    "12 - O sistema fornece um histórico dos comandos entrados pelo usuário durante uma sessão de trabalho?"
                };

                    //LEGIBILIDADE
                    Legibilidade = new List<string>
                {
                    "1 - As áreas livres são usadas para separar grupos lógicos em vez de tê-los todos de um só lado da tela, caixa ou janela?",
                    "2 - Os grupos de objetos de controle e de apresentação que compõem as caixas de diálogo e outros objetos compostos encontram-se alinhados vertical e horizontalmente?",
                    "3 - Os rótulos de campos organizados verticalmente e muito diferentes em tamanho estão justificados à direita?",
                    "4 - A largura mínima dos mostradores de texto é de 50 caracteres?",
                    "5 - A altura mínima dos mostradores de texto é de 4 linhas?",
                    "6 - Os parágrafos de texto são separados por, pelo menos, uma linha em branco?",
                    "7 - O uso exclusivo de maiúsculas nos textos é evitado?",
                    "8 - O uso do negrito é minimizado?",
                    "9 - O uso do sublinhado é minimizado?",
                    "10 - Nas tabelas, linhas em branco são empregadas para separar grupos?",
                    "11 - As listas de dados alfabéticos são justificadas à esquerda?",
                    "12 - As listas contendo números decimais apresentam alinhamento pela vírgula?",
                    "13 - As linhas empregadas para o enquadramento e segmentação de menus (separadores, delimitadores etc.) são simples?",
                    "14 - As bordas dos painéis dos menus estão suficientemente separadas dos textos das opções de modo a não prejudicar a sua legibilidade?",
                    "15 - O uso de abreviaturas é minimizado nos menus?",
                    "16 - Os nomes das opções estão somente com a inicial em maiúsculo?",
                    "17 - Os números que indicam as opções de menu estão alinhados pela direita?",
                    "18 - Quando a enumeração alfabética é utilizada, as letras para seleção estão alinhadas pela esquerda?",
                    "19 - As opções das barras de menu horizontal estão separadas por, no mínimo, 2 caracteres brancos?",
                    "20 -  Os rótulos de campos começam com uma letra maiúscula, e as letras restantes são minúsculas?",
                    "21 - Os itens de dados longos são particionados em grupos mais curtos, tanto nas entradas como nas apresentações?",
                    "22 - Os códigos alfanuméricos do sistema agrupam separadamente letras e números?",
                    "23 - Os ícones são legíveis?",
                    "24 - O sistema utiliza rótulos (textuais) quando pode existir ambiguidade de ícones?",
                    "25 - A informação codificada com o vídeo reverso é legível?",
                    "26 - O uso de vídeo reverso está restrito à indicação de feedback de seleção?",
                    "27 - Os dados a serem lidos são apresentados de forma contínua, ou seja, não piscantes ?"
                };
                // CONCISAO
                Concisao = new List<string>()
                {
                    "1 - O sistema oferece valores defaults para acelerar a entrada de dados?",
                    "2 - A identificação alfanumérica das janelas é curta o suficiente para ser relembrada facilmente?",
                    "3 - Os nomes das opções de menu são concisos?",
                    "4 - Os ícones são econômicos sob o ponto de vista do espaço nas telas?",
                    "5 - As denominações são breves?",
                    "6 - As abreviaturas são curtas?",
                    "7 - Os códigos arbitrários que o usuário deve memorizar são sempre menores do que 4 ou 5 caracteres?",
                    "8 - Os rótulos são concisos?",
                    "9 - Códigos alfanuméricos não significativos para o usuário e que devem ser entrados no sistema são menores do que 7 caracteres?",
                    "10 - Na entrada de dados alfanuméricos, o sistema considera as letras maiúsculas e minúsculas como equivalentes?",
                    "11 - Na entrada de dados numéricos, o usuário é liberado do preenchimento do ponto decimal desnecessário?",
                    "12 - Na entrada de dados numéricos, o usuário é liberado do preenchimento do zeros fracionários desnecessários?",
                    "13 - Na entrada de valores métricos ou financeiros, o usuário é liberado do preenchimento da unidade de medida?",
                    "14 - É permitido ao usuário reaproveitar os valores definidos para entradas anteriores, podendo inclusive alterá-los?"
                };
                // AÇOES MINIMAS
                AcoesMinimas = new List<string>
                {
                    "1 - Em formulário de entrada de dados o sistema posiciona o cursor no começo do primeiro campo de entrada?",
                    "2 - Na realização das ações principais em uma caixa de diálogo, o usuário tem os movimentos de cursor minimizados através da adequada ordenação dos objetos?",
                    "3 - O usuário dispõe de um modo simples e rápido (tecla TAB por exemplo) para a navegação entre os campos de um formulário?",
                    "4 - Os grupos de botões de comando possuem sempre um botão definido como default?",
                    "5 - A estrutura dos menus é concebida de modo a diminuir os passos necessários para a seleção?"
                };
                //  DENSIDADE INFORMACIONAL
                DensidadeInformacional = new List<string>
                {
                    "1 - A densidade informacional das janelas é reduzida?",
                    "2 - As telas apresentam somente os dados e informações necessários e indispensáveis para o usuário em sua tarefa?",
                    "3 - Na entrada de dados codificados, os códigos apresentam somente os dados necessários estão presentes na tela de uma maneira distinguível?",
                    "4 - O sistema minimiza a necessidade do usuário lembrar dados exatos de uma tela para outra?",
                    "5 - Na leitura de uma janela, o usuário tem seus movimentos oculares minimizados através da distribuição dos objetos principais segundo as linhas de um \"Z\" ?",
                    "6 - O sistema evita apresentar um grande número de janelas que podem desconcentrar ou sobrecarregar a memória do usuário?",
                    "7 - Na manipulação dos dados apresentados pelo sistema, o usuário está liberado da tradução de unidades?",
                    "8 - As listas de seleção e combinação apresentam uma altura correspondente a um máximo de nove linhas?",
                    "9 - Os painéis de menu apresentam como ativas somente as opções necessárias?"
                };
                //  ACOES EXPLICITAS
                AcoesExplicitas = new List<string>
                {
                    "1 - O sistema posterga os processamentos até que as ações de entrada do usuário tenham sido completadas?",
                    "2 - Durante a seleção de uma opção de menu o sistema permite a separação entre indicação e execução da opção ?",
                    "3 - Para iniciar o processamento dos dados, o sistema sempre exige do usuário uma ação explícita de \"ENTER\"?",
                    "4 - É sempre o usuário quem comanda a navegação entre os campos de um formulário?"
                };
                //  CONTROLE DE USUARIO
                ControleUsuario = new List<string>
                {
                    "1 - O usuário pode terminar um diálogo seqüencial repetitivo a qualquer instante?",
                    "2 - O usuário pode interromper e retomar um diálogo seqüencial a qualquer instante?",
                    "3 - O usuário pode reiniciar um diálogo seqüencial a qualquer instante?",
                    "4 - Durante os períodos de bloqueio dos dispositivos de entrada, o sistema fornece ao usuário uma opção para interromper o processo que causou o bloqueio?"
                };
                // FLEXIBILIDADE
                Flexibilidade = new List<string>
                {
                    "1 - Os usuários têm a possibilidade de modificar ou eliminar itens irrelevantes das janelas?",
                    "2 - Ao usuário é permitido personalizar o diálogo, através da definição de macros?",
                    "3 - É permitido ao usuário alterar e personalizar valores definidos por default?"
                };
                //EXPERIENCIA DE USUARIO
                ExpUsuario = new List<string>
                {
                    "1 - Caso se trate de um sistema de grande público, ele oferece formas variadas de apresentar as mesmas informações aos diferentes tipos de usuário?",
                    "2 - Os estilos de diálogo são compatíveis com as habilidades do usuário, permitindo ações passo-a-passo para iniciantes e a entrada de comandos mais complexos por usuários experimentados?",
                    "3 - O usuário pode se deslocar de uma parte da estrutura de menu para outra rapidamente?",
                    "4 - O sistema oferece equivalentes de teclado para a seleção e execução das opções de menu, além do dispositivo de apontamento (mouse,...)?",
                    "5 - O sistema é capaz de reconhecer um conjunto de sinônimos para os termos básicos definidos na linguagem de comando, isto para se adap tar aos usuários novatos ou ocasionais?",
                    "6 - O usuário experiente pode efetuar a digitação de vários comandos antes de uma confirmação?"
                };
                //PROTECAO CONTRA ERROS
                ProtecaoContraErros = new List<string>
                {
                    "1 - O sistema apresenta uma separação adequada entre áreas selecionáveis de um painel de menu de modo a minimizar as ativações acidentais?",
                    "2 - Em toda ação destrutiva, os botões selecionados por default realizam a anulação dessa ação?",
                    "3 - Os campos numéricos para entrada de dados longos estão subdivididos em grupos menores e pontuados com espaços, vírgulas, hífens ou barras?",
                    "4 - Ao final de uma sessão de trabalho o sistema informa sobre o risco de perda dos dados?",
                    "5 - O sistema emite sinais sonoros quando ocorrem problemas na entrada de dados?",
                    "6 - As teclas de funções perigosas encontram-se agrupadas e/ou separadas das demais no teclado?",
                    "7 - O sistema solicita confirmação (dupla) de ações que podem gerar perdas de dados e/ou resultados catastróficos?"
                };
                //MENSAGENS DE ERRO
                MsgsErro = new List<string>
                {
                    "1 - As mensagens de erro ajudam a resolver o problema do usuário, fornecendo com precisão o local e a causa específica ou provável do erro, bem como as ações que o usuário poderia realizar para corrigí-lo?",
                    "2 - As mensagens de erro são neutras e polidas?",
                    "3 - As frases das mensagens de erro são curtas e construídas a partir de palavras curtas, significativas e de uso comum?",
                    "4 - As mensagens de erro estão isentas de abreviaturas e/ou códigos gerados pelo sistema operacional?",
                    "5 - O usuário pode escolher o nível de detalhe das mensagens de erro em função de seu nível de conhecimento?",
                    "6 - A informação principal de uma mensagem de erro encontra-se logo no início da mensagem?",
                    "7 - Quando necessário, as informações que o usuário deve memorizar encontram-se localizadas na parte final da mensagem de erro?",
                    "8 - Em situações normais as mensagens de erro são escritas em maiúsculo/minúsculo?",
                    "9 - As mensagens de erro têm seu conteúdo modificado quando na repetição imediata do mesmo erro pelo mesmo usuário?"
                };
                // CORREÇAO DE ERROS
                CorrecaoErros = new List<string>
                {
                    "1 - Qualquer ação do usuário pode ser revertida através da opção DESFAZER?",
                    "2 - Através da opção REFAZER, a regressão do diálogo, também pode ser desfeita?",
                    "3 - Os comandos para DESFAZER e REFAZER o diálogo estão diferenciados?",
                    "4 - O sistema reconhece e através de uma confirmação do usuário, executa os comandos mais freqüentes mesmo com erros de ortografia?",
                    "5 - Depois de um erro de digitação de um comando ou de dados, o usuário tem a possibilidade de corrigir somente a parte dos dados ou do comando que está errada?"
                };
                //CONSISTENCIA
                Consistencia = new List<string>
                {
                    "1 - A identificação das caixas, telas ou janelas são únicas?",
                    "2 - A organização em termos da localização das várias características das janelas é mantida consistente de uma tela para outra?",
                    "3 - A posição inicial do cursor é mantida consistente ao longo de todas as apresentações de formulários?",
                    "4 - Uma mesma tecla de função aciona a mesma opção de uma tela para outra?",
                    "5 - Os ícones são distintos uns dos outros e possuem sempre o mesmo significado de uma tela para outra?",
                    "6 - A localização dos dados é mantida consistente de uma tela para outra?",
                    "7 - Os formatos de apresentação dos dados são mantidos consistentes de uma tela para outra?",
                    "8 - Os rótulos estão na mesma posição em relação aos campos associados?",
                    "9 - O símbolo para convite à entrada de dados é padronizado (por exemplo \" : \" )?",
                    "10 - As áreas de entrada de comandos estão na mesma posição de uma tela para outra?",
                    "11 - Os significados dos códigos de cores são seguidos de maneira consistente?"
                };
                //SIGNIFICADOS
                Significados = new List<string>
                {
                    "1 - As denominações dos títulos estão de acordo com o que eles representam?",
                    "2 - Os títulos das páginas de menu   são explicativos, refletindo a natureza da escolha a ser feita?",
                    "3 - Os títulos das páginas de menu são distintos entre si?",
                    "4 - Os títulos das páginas de menu são combináveis ou componíveis?",
                    "5 - As denominações das opções de menu são familiares ao usuário?",
                    "6 - O vocabulário utilizado nos rótulos, convites e mensagens de orientação são familiares ao usuário, evitando palavras difíceis?",
                    "7 - O vocabulário utilizado em rótulos, convites e mensagens de orientação é orientado à tarefa, utilizando termos e jargão técnico normalmente empregados na tarefa?",
                    "8 - Os cabeçalhos de colunas de dados são significativos e distintos?",
                    "9 - O sistema adota códigos significativos ou familiares aos usuários?",
                    "10 - As abreviaturas são significativas?",
                    "11 - As abreviaturas são facilmente distinguíveis umas das outras, evitando confusões geradas por similaridade?",
                    "12 - A intermitência luminosa (pisca-pisca)   é usada com moderação e somente para atrair a atenção para alarmes, avisos ou mensagens críticas?"
                };
                //COMPATIBILIDADE
                Compatibilidade = new List<string>
                {
                    "1 - As telas são compatíveis com o padrão do ambiente?",
                    "2 - A imagem do formulário na tela do terminal assemelha-se com o formulário de entrada em papel?",
                    "3 - O sistema propõe uma caixa de diálogo modal, quando a aplicação deve ter todos os dados antes de prosseguir ou quando o usuário tenha de responder a uma questão urgente?",
                    "4 - As caixas de diálogo do sistema apresentam um botão de validação, um botão de anulação e, se possível, um botão de ajuda?",
                    "5 - Os significados usuais das cores são respeitados nos códigos de cores definidos?",
                    "6 - As opções de codificação por cores são limitadas em número?",
                    "7 - As informações codificadas através das cores apresentam uma codificação adicional redundante?",
                    "8 - A taxa de intermitência para elementos piscantes está entre 2 e 5 Hz (2 a 5 piscadas por segundo)?",
                    "9 - A apresentação sonora é compatível com o ruído do ambiente?",
                    "10 - As mensagens são sempre afirmativas e na voz ativa?",
                    "11 - Quando uma frase descreve uma seqüência de eventos, a ordem das palavras na frase corresponde à seqüência temporal dos eventos?",
                    "12 - Ilustrações e animações são usadas para completar as explicações do texto?",
                    "13 - O sistema segue as convenções dos usuários para dados padronizados?",
                    "14 - O sistema utiliza unidades de medida familiares ao usuário?",
                    "15 - Dados numéricos que se alterem rapidamente são apresentados analogicamente?",
                    "16 - Dados numéricos que demandam precisão de leitura são apresentados digitalmente?",
                    "17 - Os itens são numerados com números, não com letras?",
                    "18 - Os identificadores numéricos de opção de menu iniciam de \"1\", e não de \"0\"?",
                    "19 - Os eixos de um gráfico apresentam escalas numéricas iniciando em zero, com intervalos padronizados, crescendo da esquerda para a direita e de cima para baixo?",
                    "20 - Os itens de um grupo de botões de rádio são mutuamente exclusivos?",
                    "21 - Os itens de um grupo de caixas de atribuição permitem escolhas independentes?"
                };
            }
            

        }
    }
}