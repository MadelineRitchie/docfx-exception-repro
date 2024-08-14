module lib.Library

let (|Null|_|) value = if isNull value then Some() else None
