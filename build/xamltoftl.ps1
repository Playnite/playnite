# Converts XAML based localization string to Project Fluent format

$ErrorActionPreference = 'Stop'
$xamlFile = "..\source\Playnite\Localization\LocSource.xaml"
$ftlOutFile = "..\source7\Playnite\Localization\en_US.ftl"

Remove-Item $ftlOutFile -EA 0
[xml]$langXml = Get-Content -LiteralPath $xamlFile -Raw

$sb = New-Object System.Text.StringBuilder
foreach ($node in $langXml.ResourceDictionary.ChildNodes | ForEach { $_ })
{
    if ($node.Name -eq "#comment")
    {
        continue
    }

    $stringName = $node.GetAttribute('x:Key')
    if ($stringName.StartsWith("LOC", 'Ordinal'))
    {
        $stringName = $stringName.Substring(3)
    }

    $stringName = $stringName -creplace "(?<!_)([A-Z]{2,})", { "-$_".ToLower() }
    $stringName = $stringName -creplace "(?<!_)([A-Z])", { "-$_".ToLower() }
    $stringName = $stringName.Trim("-")

    if ($node.GetAttribute("xml:space"))
    {
        $res = $stringName + " = `r`n    " + ($node.InnerText.Trim() -replace '\n', "`r`n    ")
    }
    else
    {
        $res = $stringName + " = " + $node.InnerText.Trim() 
    }

    $res = $res -replace "(?<!_){(\d)}", { "{`$var$($_.ToString().Trim("{}"))}" }
    $sb.AppendLine($res) | Out-Null
}

$sb.ToString() | Out-File $ftlOutFile -Encoding utf8