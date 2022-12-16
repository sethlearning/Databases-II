function HashGenerator
{
    Param(
        [string]$String
    )

    $SHA256 = [System.Security.Cryptography.SHA256]::Create()
    $UTF8 = [System.Text.UTF8Encoding]::new()
    $SB = [System.Text.StringBuilder]::new()
    $HashBytes = $SHA256.ComputeHash($UTF8.GetBytes($String))
    foreach ($byte in $HashBytes)
    {
        $SB.Append($byte.ToString('X2')) | Out-Null
    }

    return $SB.ToString()
}




function HashGenerator2
{
    Param(
        $String
    )

    $MemoryStream = [System.IO.MemoryStream]::new()
    $StreamWriter = [System.IO.StreamWriter]::new($MemoryStream)
    $StreamWriter.Write($String)
    $StreamWriter.Flush()
    $MemoryStream.Position = 0
    Get-FileHash -InputStream $MemoryStream
}

HashGenerator -String '1'
HashGenerator2 -String '1' | % Hash

HashGenerator -String '2'
HashGenerator2 -String '2' | % Hash

HashGenerator -String '3'
HashGenerator2 -String '3' | % Hash

HashGenerator -String '4'
HashGenerator2 -String '4' | % Hash

HashGenerator -String '5'
HashGenerator2 -String '5' | % Hash