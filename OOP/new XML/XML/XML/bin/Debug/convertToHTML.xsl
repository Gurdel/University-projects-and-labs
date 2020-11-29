<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
    xmlns:msxsl="urn:schemas-microsoft-com:xslt" exclude-result-prefixes="msxsl"
>
  <xml:output method="html" indent="yes"/>
    <xsl:template match="phones">
      <html>
        <body>
        <table border="1">

          <TR>
            <TD>
              <strong>Firm</strong>
            </TD>
            <TD>
              <strong>Model</strong>
            </TD>
            <TD>
              <strong>RAM</strong>
            </TD>
            <TD>
              <strong>ROM</strong>
            </TD>
            <TD>
              <strong>Battery</strong>
            </TD>
            <TD>
              <strong>Processor</strong>
            </TD>
            <TD>
              <strong>OS</strong>
            </TD>
            <TD>
              <strong>Diagonal of screen</strong>
            </TD>
            <TD>
              <strong>Resolution</strong>
            </TD>
            <TD>
              <strong>Type of display</strong>
            </TD>
          </TR>

          <xsl:for-each select="phone">

            <TR>
              <TD>
                <b>
                  <xsl:value-of select="@FIRM"/>
                </b>
              </TD>
              <TD>
                <xsl:value-of select="@MODEL"/>
              </TD>
              <TD>
                <xsl:value-of select="@RAM"/>
              </TD>
              <TD>
                <xsl:value-of select="@ROM"/>
              </TD>
              <TD>
                <xsl:value-of select="@BATTERY"/>
              </TD>
              <TD>
                <xsl:value-of select="@PROCESSOR"/>
              </TD>
              <TD>
                <xsl:value-of select="@OS"/>
              </TD>
              <TD>
                <xsl:value-of select="@DIAGONAL"/>
              </TD>
              <TD>
                <xsl:value-of select="@RESOLUTION"/>
              </TD>
              <TD>
                <xsl:value-of select="@MATRIX"/>
              </TD>
            </TR>
          </xsl:for-each>

        </table>
        </body>
      </html>
    </xsl:template>
  
</xsl:stylesheet>