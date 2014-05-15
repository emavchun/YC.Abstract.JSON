module YC.ReSharper.AbstractAnalysis.Languages.JSON

open System.IO
open JSON.Parser

let tokenize lexerInputGraph =
    let eof = RNGLR_EOF("",[||])
    Lexer._fslex_tables.Tokenize(Lexer.fslex_actions_token, lexerInputGraph, eof)

let parser = new Yard.Generators.RNGLR.AbstractParser.Parser<_>()

let parse (*parser:Yard.Generators.RNGLR.AbstractParser.Parser<_>*) =
    
    fun parserInputGraph -> parser.Parse buildAstAbstract parserInputGraph

