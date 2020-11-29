<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
  <xml:output method="html" indent="yes"/>
  <xsl:template match="phones">

    <table border="1">
      <xsl:for-each select="phone">
        <TR>
          <TD>
            <strong>Firm</strong>
          </TD>
          <TD>
            <b>
              <xsl:value-of select="@FIRM"/>
            </b>
          </TD>
        </TR>
        <TR>
          <TD>
            <strong>Model</strong>
          </TD>
          <TD>
            <b>
              <xsl:value-of select="@MODEL"/>
            </b>
          </TD>
        </TR>
        <TR>
          <TD>
            <strong>RAM</strong>
          </TD>
          <TD>
            <xsl:value-of select="@RAM"/>
          </TD>
        </TR>
        <TR>
          <TD>
            <strong>ROM</strong>
          </TD>
          <TD>
            <xsl:value-of select="@ROM"/>
          </TD>
        </TR>
        <TR>
          <TD>
            <strong>Battery</strong>
          </TD>
          <TD>
            <xsl:value-of select="@BATTERY"/>
          </TD>
        </TR>
        <TR>
          <TD>
            <strong>Processor</strong>
          </TD>
          <TD>
            <xsl:value-of select="@PROCESSOR"/>
          </TD>
        </TR>
        <TR>
          <TD>
            <strong>OS</strong>
          </TD>
          <TD>
            <xsl:value-of select="@OS"/>
          </TD>
        </TR>
        <TR>
          <TD>
            <strong>Diagonal of screen</strong>
          </TD>
          <TD>
            <xsl:value-of select="@DIAGONAL"/>
          </TD>
        </TR>
        <TR>
          <TD>
            <strong>Resolution</strong>
          </TD>
          <TD>
            <xsl:value-of select="@RESOLUTION"/>
          </TD>

        </TR>
        <TR>
          <TD>
            <strong>Type of display</strong>
          </TD>
          <TD>
            <xsl:value-of select="@MATRIX"/>
          </TD>
        </TR>



        <TR>

        </TR>
      </xsl:for-each>

    </table>

  </xsl:template>

</xsl:stylesheet>