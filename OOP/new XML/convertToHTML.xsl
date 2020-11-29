<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
    xmlns:msxsl="urn:schemas-microsoft-com:xslt" exclude-result-prefixes="msxsl"
>
    <xsl:output method="xml" indent="yes"/>
  
    <xsl:template match="Phones">

      <table border="1">

        <TR bgcolor="#008000">
          <TD><strong>��������</strong></TD>
          <TD><strong>������</strong></TD>
          <TD><strong>���������� ���'���</strong></TD> 
          <TD><strong>��������� ���'���</strong></TD>
          <TD><strong>������ �����������</strong></TD>
          <TD><strong>��������</strong></TD>
          <TD><strong>����������� ��</strong></TD>
	  <TD><strong>ĳ������� ������</strong></TD>
<TD><strong>�������� ��������</strong></TD>
<TD><strong>��� �������</strong></TD>
        </TR>

        <xsl:for-each select="phone">
          
        <TR>
          <TD><b><xsl:value-of select="@FIRM"/></b></TD>
          <TD><xsl:value-of select="@MODEL"/></TD>
          <TD><xsl:value-of select="@RAM"/></TD>
          <TD><xsl:value-of select="@ROM"/></TD>
          <TD><xsl:value-of select="@BATTERY"/></TD>
          <TD><xsl:value-of select="@PROCESSOR"/></TD>
          <TD><xsl:value-of select="@OS"/></TD>
<TD><xsl:value-of select="@DIAGONAL"/></TD>
<TD><xsl:value-of select="@RESOLUTION"/></TD>
<TD><xsl:value-of select="@MATRIX"/></TD>
        </TR>
        </xsl:for-each>
 
      </table>

  
    </xsl:template>
  
</xsl:stylesheet>