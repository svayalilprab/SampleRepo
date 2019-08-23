using Microsoft.EntityFrameworkCore.Migrations;

namespace DXC.LM.Core.ReferenceDataAPI.Endpoints.Migrations
{
    public partial class InitialSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "ReferenceDataItems",
                columns: new[] { "ID", "Key", "Path", "Value" },
                values: new object[,]
                {
                    { 1, "AFG", "Country:name", "Afghanistan" },
                    { 1631, "MNP", "Country:alpha-2", "MP" },
                    { 1632, "MNP", "Country:alpha-3", "MNP" },
                    { 1633, "MNP", "Country:country-code", "580" },
                    { 1634, "MNP", "Country:iso_3166-2", "ISO 3166-2:MP" },
                    { 1635, "MNP", "Country:region", "Oceania" },
                    { 1636, "MNP", "Country:sub-region", "Micronesia" },
                    { 1637, "MNP", "Country:region-code", "009" },
                    { 1638, "MNP", "Country:sub-region-code", "057" },
                    { 1639, "NOR", "Country:name", "Norway" },
                    { 1640, "NOR", "Country:alpha-2", "NO" },
                    { 1641, "NOR", "Country:alpha-3", "NOR" },
                    { 1642, "NOR", "Country:country-code", "578" },
                    { 1643, "NOR", "Country:iso_3166-2", "ISO 3166-2:NO" },
                    { 1644, "NOR", "Country:region", "Europe" },
                    { 1645, "NOR", "Country:sub-region", "Northern Europe" },
                    { 1630, "MNP", "Country:name", "Northern Mariana Islands" },
                    { 1646, "NOR", "Country:region-code", "150" },
                    { 1629, "MKD", "Country:sub-region-code", "039" },
                    { 1627, "MKD", "Country:sub-region", "Southern Europe" },
                    { 1612, "NFK", "Country:name", "Norfolk Island" },
                    { 1613, "NFK", "Country:alpha-2", "NF" },
                    { 1614, "NFK", "Country:alpha-3", "NFK" },
                    { 1615, "NFK", "Country:country-code", "574" },
                    { 1616, "NFK", "Country:iso_3166-2", "ISO 3166-2:NF" },
                    { 1617, "NFK", "Country:region", "Oceania" },
                    { 1618, "NFK", "Country:sub-region", "Australia and New Zealand" },
                    { 1619, "NFK", "Country:region-code", "009" },
                    { 1620, "NFK", "Country:sub-region-code", "053" },
                    { 1621, "MKD", "Country:name", "North Macedonia" },
                    { 1622, "MKD", "Country:alpha-2", "MK" },
                    { 1623, "MKD", "Country:alpha-3", "MKD" },
                    { 1624, "MKD", "Country:country-code", "807" },
                    { 1625, "MKD", "Country:iso_3166-2", "ISO 3166-2:MK" },
                    { 1626, "MKD", "Country:region", "Europe" },
                    { 1628, "MKD", "Country:region-code", "150" },
                    { 1611, "NIU", "Country:sub-region-code", "061" },
                    { 1647, "NOR", "Country:sub-region-code", "154" },
                    { 1649, "OMN", "Country:alpha-2", "OM" },
                    { 1669, "PLW", "Country:country-code", "585" },
                    { 1670, "PLW", "Country:iso_3166-2", "ISO 3166-2:PW" },
                    { 1671, "PLW", "Country:region", "Oceania" },
                    { 1672, "PLW", "Country:sub-region", "Micronesia" },
                    { 1673, "PLW", "Country:region-code", "009" },
                    { 1674, "PLW", "Country:sub-region-code", "057" },
                    { 1675, "PSE", "Country:name", "Palestine" },
                    { 1676, "PSE", "Country:alpha-2", "PS" },
                    { 1677, "PSE", "Country:alpha-3", "PSE" },
                    { 1678, "PSE", "Country:country-code", "275" },
                    { 1679, "PSE", "Country:iso_3166-2", "ISO 3166-2:PS" },
                    { 1680, "PSE", "Country:region", "Asia" },
                    { 1681, "PSE", "Country:sub-region", "Western Asia" },
                    { 1682, "PSE", "Country:region-code", "142" },
                    { 1683, "PSE", "Country:sub-region-code", "145" },
                    { 1668, "PLW", "Country:alpha-3", "PLW" },
                    { 1648, "OMN", "Country:name", "Oman" },
                    { 1667, "PLW", "Country:alpha-2", "PW" },
                    { 1665, "PAK", "Country:sub-region-code", "034" },
                    { 1650, "OMN", "Country:alpha-3", "OMN" },
                    { 1651, "OMN", "Country:country-code", "512" },
                    { 1652, "OMN", "Country:iso_3166-2", "ISO 3166-2:OM" },
                    { 1653, "OMN", "Country:region", "Asia" },
                    { 1654, "OMN", "Country:sub-region", "Western Asia" },
                    { 1655, "OMN", "Country:region-code", "142" },
                    { 1656, "OMN", "Country:sub-region-code", "145" },
                    { 1657, "PAK", "Country:name", "Pakistan" },
                    { 1658, "PAK", "Country:alpha-2", "PK" },
                    { 1659, "PAK", "Country:alpha-3", "PAK" },
                    { 1660, "PAK", "Country:country-code", "586" },
                    { 1661, "PAK", "Country:iso_3166-2", "ISO 3166-2:PK" },
                    { 1662, "PAK", "Country:region", "Asia" },
                    { 1663, "PAK", "Country:sub-region", "Southern Asia" },
                    { 1664, "PAK", "Country:region-code", "142" },
                    { 1666, "PLW", "Country:name", "Palau" },
                    { 1610, "NIU", "Country:region-code", "009" },
                    { 1609, "NIU", "Country:sub-region", "Polynesia" },
                    { 1608, "NIU", "Country:region", "Oceania" },
                    { 1554, "NCL", "Country:alpha-3", "NCL" },
                    { 1555, "NCL", "Country:country-code", "540" },
                    { 1556, "NCL", "Country:iso_3166-2", "ISO 3166-2:NC" },
                    { 1557, "NCL", "Country:region", "Oceania" },
                    { 1558, "NCL", "Country:sub-region", "Melanesia" },
                    { 1559, "NCL", "Country:region-code", "009" },
                    { 1560, "NCL", "Country:sub-region-code", "054" },
                    { 1561, "NZL", "Country:name", "New Zealand" },
                    { 1562, "NZL", "Country:alpha-2", "NZ" },
                    { 1563, "NZL", "Country:alpha-3", "NZL" },
                    { 1564, "NZL", "Country:country-code", "554" },
                    { 1565, "NZL", "Country:iso_3166-2", "ISO 3166-2:NZ" },
                    { 1566, "NZL", "Country:region", "Oceania" },
                    { 1567, "NZL", "Country:sub-region", "Australia and New Zealand" },
                    { 1568, "NZL", "Country:region-code", "009" },
                    { 1553, "NCL", "Country:alpha-2", "NC" },
                    { 1569, "NZL", "Country:sub-region-code", "053" },
                    { 1552, "NCL", "Country:name", "New Caledonia" },
                    { 1550, "NLD", "Country:region-code", "150" },
                    { 1535, "NPL", "Country:alpha-2", "NP" },
                    { 1536, "NPL", "Country:alpha-3", "NPL" },
                    { 1537, "NPL", "Country:country-code", "524" },
                    { 1538, "NPL", "Country:iso_3166-2", "ISO 3166-2:NP" },
                    { 1539, "NPL", "Country:region", "Asia" },
                    { 1540, "NPL", "Country:sub-region", "Southern Asia" },
                    { 1541, "NPL", "Country:region-code", "142" },
                    { 1542, "NPL", "Country:sub-region-code", "034" },
                    { 1543, "NLD", "Country:name", "Netherlands" },
                    { 1544, "NLD", "Country:alpha-2", "NL" },
                    { 1545, "NLD", "Country:alpha-3", "NLD" },
                    { 1546, "NLD", "Country:country-code", "528" },
                    { 1547, "NLD", "Country:iso_3166-2", "ISO 3166-2:NL" },
                    { 1548, "NLD", "Country:region", "Europe" },
                    { 1549, "NLD", "Country:sub-region", "Western Europe" },
                    { 1551, "NLD", "Country:sub-region-code", "155" },
                    { 1570, "NIC", "Country:name", "Nicaragua" },
                    { 1571, "NIC", "Country:alpha-2", "NI" },
                    { 1572, "NIC", "Country:alpha-3", "NIC" },
                    { 1593, "NGA", "Country:alpha-2", "NG" },
                    { 1594, "NGA", "Country:alpha-3", "NGA" },
                    { 1595, "NGA", "Country:country-code", "566" },
                    { 1596, "NGA", "Country:iso_3166-2", "ISO 3166-2:NG" },
                    { 1597, "NGA", "Country:region", "Africa" },
                    { 1598, "NGA", "Country:sub-region", "Sub-Saharan Africa" },
                    { 1599, "NGA", "Country:intermediate-region", "Western Africa" },
                    { 1600, "NGA", "Country:region-code", "002" },
                    { 1601, "NGA", "Country:sub-region-code", "202" },
                    { 1602, "NGA", "Country:intermediate-region-code", "011" },
                    { 1603, "NIU", "Country:name", "Niue" },
                    { 1604, "NIU", "Country:alpha-2", "NU" },
                    { 1605, "NIU", "Country:alpha-3", "NIU" },
                    { 1606, "NIU", "Country:country-code", "570" },
                    { 1607, "NIU", "Country:iso_3166-2", "ISO 3166-2:NU" },
                    { 1592, "NGA", "Country:name", "Nigeria" },
                    { 1591, "NER", "Country:intermediate-region-code", "011" },
                    { 1590, "NER", "Country:sub-region-code", "202" },
                    { 1589, "NER", "Country:region-code", "002" },
                    { 1573, "NIC", "Country:country-code", "558" },
                    { 1574, "NIC", "Country:iso_3166-2", "ISO 3166-2:NI" },
                    { 1575, "NIC", "Country:region", "Americas" },
                    { 1576, "NIC", "Country:sub-region", "Latin America and the Caribbean" },
                    { 1577, "NIC", "Country:intermediate-region", "Central America" },
                    { 1578, "NIC", "Country:region-code", "019" },
                    { 1579, "NIC", "Country:sub-region-code", "419" },
                    { 1684, "PAN", "Country:name", "Panama" },
                    { 1580, "NIC", "Country:intermediate-region-code", "013" },
                    { 1582, "NER", "Country:alpha-2", "NE" },
                    { 1583, "NER", "Country:alpha-3", "NER" },
                    { 1584, "NER", "Country:country-code", "562" },
                    { 1585, "NER", "Country:iso_3166-2", "ISO 3166-2:NE" },
                    { 1586, "NER", "Country:region", "Africa" },
                    { 1587, "NER", "Country:sub-region", "Sub-Saharan Africa" },
                    { 1588, "NER", "Country:intermediate-region", "Western Africa" },
                    { 1581, "NER", "Country:name", "Niger" },
                    { 1534, "NPL", "Country:name", "Nepal" },
                    { 1685, "PAN", "Country:alpha-2", "PA" },
                    { 1687, "PAN", "Country:country-code", "591" },
                    { 1784, "REU", "Country:alpha-3", "REU" },
                    { 1785, "REU", "Country:country-code", "638" },
                    { 1786, "REU", "Country:iso_3166-2", "ISO 3166-2:RE" },
                    { 1787, "REU", "Country:region", "Africa" },
                    { 1788, "REU", "Country:sub-region", "Sub-Saharan Africa" },
                    { 1789, "REU", "Country:intermediate-region", "Eastern Africa" },
                    { 1790, "REU", "Country:region-code", "002" },
                    { 1791, "REU", "Country:sub-region-code", "202" },
                    { 1792, "REU", "Country:intermediate-region-code", "014" },
                    { 1793, "ROU", "Country:name", "Romania" },
                    { 1794, "ROU", "Country:alpha-2", "RO" },
                    { 1795, "ROU", "Country:alpha-3", "ROU" },
                    { 1796, "ROU", "Country:country-code", "642" },
                    { 1797, "ROU", "Country:iso_3166-2", "ISO 3166-2:RO" },
                    { 1798, "ROU", "Country:region", "Europe" },
                    { 1783, "REU", "Country:alpha-2", "RE" },
                    { 1799, "ROU", "Country:sub-region", "Eastern Europe" },
                    { 1782, "REU", "Country:name", "Réunion" },
                    { 1780, "QAT", "Country:region-code", "142" },
                    { 1765, "PRI", "Country:country-code", "630" },
                    { 1766, "PRI", "Country:iso_3166-2", "ISO 3166-2:PR" },
                    { 1767, "PRI", "Country:region", "Americas" },
                    { 1768, "PRI", "Country:sub-region", "Latin America and the Caribbean" },
                    { 1769, "PRI", "Country:intermediate-region", "Caribbean" },
                    { 1770, "PRI", "Country:region-code", "019" },
                    { 1771, "PRI", "Country:sub-region-code", "419" },
                    { 1772, "PRI", "Country:intermediate-region-code", "029" },
                    { 1773, "QAT", "Country:name", "Qatar" },
                    { 1774, "QAT", "Country:alpha-2", "QA" },
                    { 1775, "QAT", "Country:alpha-3", "QAT" },
                    { 1776, "QAT", "Country:country-code", "634" },
                    { 1777, "QAT", "Country:iso_3166-2", "ISO 3166-2:QA" },
                    { 1778, "QAT", "Country:region", "Asia" },
                    { 1779, "QAT", "Country:sub-region", "Western Asia" },
                    { 1781, "QAT", "Country:sub-region-code", "145" },
                    { 1764, "PRI", "Country:alpha-3", "PRI" },
                    { 1800, "ROU", "Country:region-code", "150" },
                    { 1802, "RUS", "Country:name", "Russian Federation" },
                    { 1822, "BLM", "Country:name", "Saint Barthélemy" },
                    { 1823, "BLM", "Country:alpha-2", "BL" },
                    { 1824, "BLM", "Country:alpha-3", "BLM" },
                    { 1825, "BLM", "Country:country-code", "652" },
                    { 1826, "BLM", "Country:iso_3166-2", "ISO 3166-2:BL" },
                    { 1827, "BLM", "Country:region", "Americas" },
                    { 1828, "BLM", "Country:sub-region", "Latin America and the Caribbean" },
                    { 1829, "BLM", "Country:intermediate-region", "Caribbean" },
                    { 1830, "BLM", "Country:region-code", "019" },
                    { 1831, "BLM", "Country:sub-region-code", "419" },
                    { 1832, "BLM", "Country:intermediate-region-code", "029" },
                    { 1833, "SHN", "Country:name", "Saint Helena" },
                    { 1834, "SHN", "Country:alpha-2", "SH" },
                    { 1835, "SHN", "Country:alpha-3", "SHN" },
                    { 1836, "SHN", "Country:country-code", "654" },
                    { 1821, "RWA", "Country:intermediate-region-code", "014" },
                    { 1801, "ROU", "Country:sub-region-code", "151" },
                    { 1820, "RWA", "Country:sub-region-code", "202" },
                    { 1818, "RWA", "Country:intermediate-region", "Eastern Africa" },
                    { 1803, "RUS", "Country:alpha-2", "RU" },
                    { 1804, "RUS", "Country:alpha-3", "RUS" },
                    { 1805, "RUS", "Country:country-code", "643" },
                    { 1806, "RUS", "Country:iso_3166-2", "ISO 3166-2:RU" },
                    { 1807, "RUS", "Country:region", "Europe" },
                    { 1808, "RUS", "Country:sub-region", "Eastern Europe" },
                    { 1809, "RUS", "Country:region-code", "150" },
                    { 1810, "RUS", "Country:sub-region-code", "151" },
                    { 1811, "RWA", "Country:name", "Rwanda" },
                    { 1812, "RWA", "Country:alpha-2", "RW" },
                    { 1813, "RWA", "Country:alpha-3", "RWA" },
                    { 1814, "RWA", "Country:country-code", "646" },
                    { 1815, "RWA", "Country:iso_3166-2", "ISO 3166-2:RW" },
                    { 1816, "RWA", "Country:region", "Africa" },
                    { 1817, "RWA", "Country:sub-region", "Sub-Saharan Africa" },
                    { 1819, "RWA", "Country:region-code", "002" },
                    { 1763, "PRI", "Country:alpha-2", "PR" },
                    { 1762, "PRI", "Country:name", "Puerto Rico" },
                    { 1761, "PRT", "Country:sub-region-code", "039" },
                    { 1707, "PRY", "Country:country-code", "600" },
                    { 1708, "PRY", "Country:iso_3166-2", "ISO 3166-2:PY" },
                    { 1709, "PRY", "Country:region", "Americas" },
                    { 1710, "PRY", "Country:sub-region", "Latin America and the Caribbean" },
                    { 1711, "PRY", "Country:intermediate-region", "South America" },
                    { 1712, "PRY", "Country:region-code", "019" },
                    { 1713, "PRY", "Country:sub-region-code", "419" },
                    { 1714, "PRY", "Country:intermediate-region-code", "005" },
                    { 1715, "PER", "Country:name", "Peru" },
                    { 1716, "PER", "Country:alpha-2", "PE" },
                    { 1717, "PER", "Country:alpha-3", "PER" },
                    { 1718, "PER", "Country:country-code", "604" },
                    { 1719, "PER", "Country:iso_3166-2", "ISO 3166-2:PE" },
                    { 1720, "PER", "Country:region", "Americas" },
                    { 1721, "PER", "Country:sub-region", "Latin America and the Caribbean" },
                    { 1706, "PRY", "Country:alpha-3", "PRY" },
                    { 1722, "PER", "Country:intermediate-region", "South America" },
                    { 1705, "PRY", "Country:alpha-2", "PY" },
                    { 1703, "PNG", "Country:sub-region-code", "054" },
                    { 1688, "PAN", "Country:iso_3166-2", "ISO 3166-2:PA" },
                    { 1689, "PAN", "Country:region", "Americas" },
                    { 1690, "PAN", "Country:sub-region", "Latin America and the Caribbean" },
                    { 1691, "PAN", "Country:intermediate-region", "Central America" },
                    { 1692, "PAN", "Country:region-code", "019" },
                    { 1693, "PAN", "Country:sub-region-code", "419" },
                    { 1694, "PAN", "Country:intermediate-region-code", "013" },
                    { 1695, "PNG", "Country:name", "Papua New Guinea" },
                    { 1696, "PNG", "Country:alpha-2", "PG" },
                    { 1697, "PNG", "Country:alpha-3", "PNG" },
                    { 1698, "PNG", "Country:country-code", "598" },
                    { 1699, "PNG", "Country:iso_3166-2", "ISO 3166-2:PG" },
                    { 1700, "PNG", "Country:region", "Oceania" },
                    { 1701, "PNG", "Country:sub-region", "Melanesia" },
                    { 1702, "PNG", "Country:region-code", "009" },
                    { 1704, "PRY", "Country:name", "Paraguay" },
                    { 1723, "PER", "Country:region-code", "019" },
                    { 1724, "PER", "Country:sub-region-code", "419" },
                    { 1725, "PER", "Country:intermediate-region-code", "005" },
                    { 1746, "POL", "Country:alpha-3", "POL" },
                    { 1747, "POL", "Country:country-code", "616" },
                    { 1748, "POL", "Country:iso_3166-2", "ISO 3166-2:PL" },
                    { 1749, "POL", "Country:region", "Europe" },
                    { 1750, "POL", "Country:sub-region", "Eastern Europe" },
                    { 1751, "POL", "Country:region-code", "150" },
                    { 1752, "POL", "Country:sub-region-code", "151" },
                    { 1753, "PRT", "Country:name", "Portugal" },
                    { 1754, "PRT", "Country:alpha-2", "PT" },
                    { 1755, "PRT", "Country:alpha-3", "PRT" },
                    { 1756, "PRT", "Country:country-code", "620" },
                    { 1757, "PRT", "Country:iso_3166-2", "ISO 3166-2:PT" },
                    { 1758, "PRT", "Country:region", "Europe" },
                    { 1759, "PRT", "Country:sub-region", "Southern Europe" },
                    { 1760, "PRT", "Country:region-code", "150" },
                    { 1745, "POL", "Country:alpha-2", "PL" },
                    { 1744, "POL", "Country:name", "Poland" },
                    { 1743, "PCN", "Country:sub-region-code", "061" },
                    { 1742, "PCN", "Country:region-code", "009" },
                    { 1726, "PHL", "Country:name", "Philippines" },
                    { 1727, "PHL", "Country:alpha-2", "PH" },
                    { 1728, "PHL", "Country:alpha-3", "PHL" },
                    { 1729, "PHL", "Country:country-code", "608" },
                    { 1730, "PHL", "Country:iso_3166-2", "ISO 3166-2:PH" },
                    { 1731, "PHL", "Country:region", "Asia" },
                    { 1732, "PHL", "Country:sub-region", "South-eastern Asia" },
                    { 1686, "PAN", "Country:alpha-3", "PAN" },
                    { 1733, "PHL", "Country:region-code", "142" },
                    { 1735, "PCN", "Country:name", "Pitcairn" },
                    { 1736, "PCN", "Country:alpha-2", "PN" },
                    { 1737, "PCN", "Country:alpha-3", "PCN" },
                    { 1738, "PCN", "Country:country-code", "612" },
                    { 1739, "PCN", "Country:iso_3166-2", "ISO 3166-2:PN" },
                    { 1740, "PCN", "Country:region", "Oceania" },
                    { 1741, "PCN", "Country:sub-region", "Polynesia" },
                    { 1734, "PHL", "Country:sub-region-code", "035" },
                    { 1533, "NRU", "Country:sub-region-code", "057" },
                    { 1532, "NRU", "Country:region-code", "009" },
                    { 1531, "NRU", "Country:sub-region", "Micronesia" },
                    { 1324, "MWI", "Country:region-code", "002" },
                    { 1325, "MWI", "Country:sub-region-code", "202" },
                    { 1326, "MWI", "Country:intermediate-region-code", "014" },
                    { 1327, "MYS", "Country:name", "Malaysia" },
                    { 1328, "MYS", "Country:alpha-2", "MY" },
                    { 1329, "MYS", "Country:alpha-3", "MYS" },
                    { 1330, "MYS", "Country:country-code", "458" },
                    { 1331, "MYS", "Country:iso_3166-2", "ISO 3166-2:MY" },
                    { 1332, "MYS", "Country:region", "Asia" },
                    { 1333, "MYS", "Country:sub-region", "South-eastern Asia" },
                    { 1334, "MYS", "Country:region-code", "142" },
                    { 1335, "MYS", "Country:sub-region-code", "035" },
                    { 1336, "MDV", "Country:name", "Maldives" },
                    { 1337, "MDV", "Country:alpha-2", "MV" },
                    { 1338, "MDV", "Country:alpha-3", "MDV" },
                    { 1323, "MWI", "Country:intermediate-region", "Eastern Africa" },
                    { 1339, "MDV", "Country:country-code", "462" },
                    { 1322, "MWI", "Country:sub-region", "Sub-Saharan Africa" },
                    { 1320, "MWI", "Country:iso_3166-2", "ISO 3166-2:MW" },
                    { 1305, "MDG", "Country:name", "Madagascar" },
                    { 1306, "MDG", "Country:alpha-2", "MG" },
                    { 1307, "MDG", "Country:alpha-3", "MDG" },
                    { 1308, "MDG", "Country:country-code", "450" },
                    { 1309, "MDG", "Country:iso_3166-2", "ISO 3166-2:MG" },
                    { 1310, "MDG", "Country:region", "Africa" },
                    { 1311, "MDG", "Country:sub-region", "Sub-Saharan Africa" },
                    { 1312, "MDG", "Country:intermediate-region", "Eastern Africa" },
                    { 1313, "MDG", "Country:region-code", "002" },
                    { 1314, "MDG", "Country:sub-region-code", "202" },
                    { 1315, "MDG", "Country:intermediate-region-code", "014" },
                    { 1316, "MWI", "Country:name", "Malawi" },
                    { 1317, "MWI", "Country:alpha-2", "MW" },
                    { 1318, "MWI", "Country:alpha-3", "MWI" },
                    { 1319, "MWI", "Country:country-code", "454" },
                    { 1321, "MWI", "Country:region", "Africa" },
                    { 1304, "MAC", "Country:sub-region-code", "030" },
                    { 1340, "MDV", "Country:iso_3166-2", "ISO 3166-2:MV" },
                    { 1342, "MDV", "Country:sub-region", "Southern Asia" },
                    { 1362, "MLT", "Country:sub-region", "Southern Europe" },
                    { 1363, "MLT", "Country:region-code", "150" },
                    { 1364, "MLT", "Country:sub-region-code", "039" },
                    { 1365, "MHL", "Country:name", "Marshall Islands" },
                    { 1366, "MHL", "Country:alpha-2", "MH" },
                    { 1367, "MHL", "Country:alpha-3", "MHL" },
                    { 1368, "MHL", "Country:country-code", "584" },
                    { 1369, "MHL", "Country:iso_3166-2", "ISO 3166-2:MH" },
                    { 1370, "MHL", "Country:region", "Oceania" },
                    { 1371, "MHL", "Country:sub-region", "Micronesia" },
                    { 1372, "MHL", "Country:region-code", "009" },
                    { 1373, "MHL", "Country:sub-region-code", "057" },
                    { 1374, "MTQ", "Country:name", "Martinique" },
                    { 1375, "MTQ", "Country:alpha-2", "MQ" },
                    { 1376, "MTQ", "Country:alpha-3", "MTQ" },
                    { 1361, "MLT", "Country:region", "Europe" },
                    { 1341, "MDV", "Country:region", "Asia" },
                    { 1360, "MLT", "Country:iso_3166-2", "ISO 3166-2:MT" },
                    { 1358, "MLT", "Country:alpha-3", "MLT" },
                    { 1343, "MDV", "Country:region-code", "142" },
                    { 1344, "MDV", "Country:sub-region-code", "034" },
                    { 1345, "MLI", "Country:name", "Mali" },
                    { 1346, "MLI", "Country:alpha-2", "ML" },
                    { 1347, "MLI", "Country:alpha-3", "MLI" },
                    { 1348, "MLI", "Country:country-code", "466" },
                    { 1349, "MLI", "Country:iso_3166-2", "ISO 3166-2:ML" },
                    { 1350, "MLI", "Country:region", "Africa" },
                    { 1351, "MLI", "Country:sub-region", "Sub-Saharan Africa" },
                    { 1352, "MLI", "Country:intermediate-region", "Western Africa" },
                    { 1353, "MLI", "Country:region-code", "002" },
                    { 1354, "MLI", "Country:sub-region-code", "202" },
                    { 1355, "MLI", "Country:intermediate-region-code", "011" },
                    { 1356, "MLT", "Country:name", "Malta" },
                    { 1357, "MLT", "Country:alpha-2", "MT" },
                    { 1359, "MLT", "Country:country-code", "470" },
                    { 1303, "MAC", "Country:region-code", "142" },
                    { 1302, "MAC", "Country:sub-region", "Eastern Asia" },
                    { 1301, "MAC", "Country:region", "Asia" },
                    { 1247, "LSO", "Country:sub-region-code", "202" },
                    { 1248, "LSO", "Country:intermediate-region-code", "018" },
                    { 1249, "LBR", "Country:name", "Liberia" },
                    { 1250, "LBR", "Country:alpha-2", "LR" },
                    { 1251, "LBR", "Country:alpha-3", "LBR" },
                    { 1252, "LBR", "Country:country-code", "430" },
                    { 1253, "LBR", "Country:iso_3166-2", "ISO 3166-2:LR" },
                    { 1254, "LBR", "Country:region", "Africa" },
                    { 1255, "LBR", "Country:sub-region", "Sub-Saharan Africa" },
                    { 1256, "LBR", "Country:intermediate-region", "Western Africa" },
                    { 1257, "LBR", "Country:region-code", "002" },
                    { 1258, "LBR", "Country:sub-region-code", "202" },
                    { 1259, "LBR", "Country:intermediate-region-code", "011" },
                    { 1260, "LBY", "Country:name", "Libya" },
                    { 1261, "LBY", "Country:alpha-2", "LY" },
                    { 1246, "LSO", "Country:region-code", "002" },
                    { 1262, "LBY", "Country:alpha-3", "LBY" },
                    { 1245, "LSO", "Country:intermediate-region", "Southern Africa" },
                    { 1243, "LSO", "Country:region", "Africa" },
                    { 1228, "LVA", "Country:sub-region-code", "154" },
                    { 1229, "LBN", "Country:name", "Lebanon" },
                    { 1230, "LBN", "Country:alpha-2", "LB" },
                    { 1231, "LBN", "Country:alpha-3", "LBN" },
                    { 1232, "LBN", "Country:country-code", "422" },
                    { 1233, "LBN", "Country:iso_3166-2", "ISO 3166-2:LB" },
                    { 1234, "LBN", "Country:region", "Asia" },
                    { 1235, "LBN", "Country:sub-region", "Western Asia" },
                    { 1236, "LBN", "Country:region-code", "142" },
                    { 1237, "LBN", "Country:sub-region-code", "145" },
                    { 1238, "LSO", "Country:name", "Lesotho" },
                    { 1239, "LSO", "Country:alpha-2", "LS" },
                    { 1240, "LSO", "Country:alpha-3", "LSO" },
                    { 1241, "LSO", "Country:country-code", "426" },
                    { 1242, "LSO", "Country:iso_3166-2", "ISO 3166-2:LS" },
                    { 1244, "LSO", "Country:sub-region", "Sub-Saharan Africa" },
                    { 1263, "LBY", "Country:country-code", "434" },
                    { 1264, "LBY", "Country:iso_3166-2", "ISO 3166-2:LY" },
                    { 1265, "LBY", "Country:region", "Africa" },
                    { 1286, "LTU", "Country:sub-region-code", "154" },
                    { 1287, "LUX", "Country:name", "Luxembourg" },
                    { 1288, "LUX", "Country:alpha-2", "LU" },
                    { 1289, "LUX", "Country:alpha-3", "LUX" },
                    { 1290, "LUX", "Country:country-code", "442" },
                    { 1291, "LUX", "Country:iso_3166-2", "ISO 3166-2:LU" },
                    { 1292, "LUX", "Country:region", "Europe" },
                    { 1293, "LUX", "Country:sub-region", "Western Europe" },
                    { 1294, "LUX", "Country:region-code", "150" },
                    { 1295, "LUX", "Country:sub-region-code", "155" },
                    { 1296, "MAC", "Country:name", "Macao" },
                    { 1297, "MAC", "Country:alpha-2", "MO" },
                    { 1298, "MAC", "Country:alpha-3", "MAC" },
                    { 1299, "MAC", "Country:country-code", "446" },
                    { 1300, "MAC", "Country:iso_3166-2", "ISO 3166-2:MO" },
                    { 1285, "LTU", "Country:region-code", "150" },
                    { 1284, "LTU", "Country:sub-region", "Northern Europe" },
                    { 1283, "LTU", "Country:region", "Europe" },
                    { 1282, "LTU", "Country:iso_3166-2", "ISO 3166-2:LT" },
                    { 1266, "LBY", "Country:sub-region", "Northern Africa" },
                    { 1267, "LBY", "Country:region-code", "002" },
                    { 1268, "LBY", "Country:sub-region-code", "015" },
                    { 1269, "LIE", "Country:name", "Liechtenstein" },
                    { 1270, "LIE", "Country:alpha-2", "LI" },
                    { 1271, "LIE", "Country:alpha-3", "LIE" },
                    { 1272, "LIE", "Country:country-code", "438" },
                    { 1377, "MTQ", "Country:country-code", "474" },
                    { 1273, "LIE", "Country:iso_3166-2", "ISO 3166-2:LI" },
                    { 1275, "LIE", "Country:sub-region", "Western Europe" },
                    { 1276, "LIE", "Country:region-code", "150" },
                    { 1277, "LIE", "Country:sub-region-code", "155" },
                    { 1278, "LTU", "Country:name", "Lithuania" },
                    { 1279, "LTU", "Country:alpha-2", "LT" },
                    { 1280, "LTU", "Country:alpha-3", "LTU" },
                    { 1281, "LTU", "Country:country-code", "440" },
                    { 1274, "LIE", "Country:region", "Europe" },
                    { 1378, "MTQ", "Country:iso_3166-2", "ISO 3166-2:MQ" },
                    { 1379, "MTQ", "Country:region", "Americas" },
                    { 1380, "MTQ", "Country:sub-region", "Latin America and the Caribbean" },
                    { 1477, "MSR", "Country:country-code", "500" },
                    { 1478, "MSR", "Country:iso_3166-2", "ISO 3166-2:MS" },
                    { 1479, "MSR", "Country:region", "Americas" },
                    { 1480, "MSR", "Country:sub-region", "Latin America and the Caribbean" },
                    { 1481, "MSR", "Country:intermediate-region", "Caribbean" },
                    { 1482, "MSR", "Country:region-code", "019" },
                    { 1483, "MSR", "Country:sub-region-code", "419" },
                    { 1484, "MSR", "Country:intermediate-region-code", "029" },
                    { 1485, "MAR", "Country:name", "Morocco" },
                    { 1486, "MAR", "Country:alpha-2", "MA" },
                    { 1487, "MAR", "Country:alpha-3", "MAR" },
                    { 1488, "MAR", "Country:country-code", "504" },
                    { 1489, "MAR", "Country:iso_3166-2", "ISO 3166-2:MA" },
                    { 1490, "MAR", "Country:region", "Africa" },
                    { 1491, "MAR", "Country:sub-region", "Northern Africa" },
                    { 1476, "MSR", "Country:alpha-3", "MSR" },
                    { 1492, "MAR", "Country:region-code", "002" },
                    { 1475, "MSR", "Country:alpha-2", "MS" },
                    { 1473, "MNE", "Country:sub-region-code", "039" },
                    { 1458, "MNG", "Country:alpha-3", "MNG" },
                    { 1459, "MNG", "Country:country-code", "496" },
                    { 1460, "MNG", "Country:iso_3166-2", "ISO 3166-2:MN" },
                    { 1461, "MNG", "Country:region", "Asia" },
                    { 1462, "MNG", "Country:sub-region", "Eastern Asia" },
                    { 1463, "MNG", "Country:region-code", "142" },
                    { 1464, "MNG", "Country:sub-region-code", "030" },
                    { 1465, "MNE", "Country:name", "Montenegro" },
                    { 1466, "MNE", "Country:alpha-2", "ME" },
                    { 1467, "MNE", "Country:alpha-3", "MNE" },
                    { 1468, "MNE", "Country:country-code", "499" },
                    { 1469, "MNE", "Country:iso_3166-2", "ISO 3166-2:ME" },
                    { 1470, "MNE", "Country:region", "Europe" },
                    { 1471, "MNE", "Country:sub-region", "Southern Europe" },
                    { 1472, "MNE", "Country:region-code", "150" },
                    { 1474, "MSR", "Country:name", "Montserrat" },
                    { 1493, "MAR", "Country:sub-region-code", "015" },
                    { 1494, "MOZ", "Country:name", "Mozambique" },
                    { 1495, "MOZ", "Country:alpha-2", "MZ" },
                    { 1516, "NAM", "Country:alpha-3", "NAM" },
                    { 1517, "NAM", "Country:country-code", "516" },
                    { 1518, "NAM", "Country:iso_3166-2", "ISO 3166-2:NA" },
                    { 1519, "NAM", "Country:region", "Africa" },
                    { 1520, "NAM", "Country:sub-region", "Sub-Saharan Africa" },
                    { 1521, "NAM", "Country:intermediate-region", "Southern Africa" },
                    { 1522, "NAM", "Country:region-code", "002" },
                    { 1523, "NAM", "Country:sub-region-code", "202" },
                    { 1524, "NAM", "Country:intermediate-region-code", "018" },
                    { 1525, "NRU", "Country:name", "Nauru" },
                    { 1526, "NRU", "Country:alpha-2", "NR" },
                    { 1527, "NRU", "Country:alpha-3", "NRU" },
                    { 1528, "NRU", "Country:country-code", "520" },
                    { 1529, "NRU", "Country:iso_3166-2", "ISO 3166-2:NR" },
                    { 1530, "NRU", "Country:region", "Oceania" },
                    { 1515, "NAM", "Country:alpha-2", "NA" },
                    { 1514, "NAM", "Country:name", "Namibia" },
                    { 1513, "MMR", "Country:sub-region-code", "035" },
                    { 1512, "MMR", "Country:region-code", "142" },
                    { 1496, "MOZ", "Country:alpha-3", "MOZ" },
                    { 1497, "MOZ", "Country:country-code", "508" },
                    { 1498, "MOZ", "Country:iso_3166-2", "ISO 3166-2:MZ" },
                    { 1499, "MOZ", "Country:region", "Africa" },
                    { 1500, "MOZ", "Country:sub-region", "Sub-Saharan Africa" },
                    { 1501, "MOZ", "Country:intermediate-region", "Eastern Africa" },
                    { 1502, "MOZ", "Country:region-code", "002" }
                });

            migrationBuilder.InsertData(
                table: "ReferenceDataItems",
                columns: new[] { "ID", "Key", "Path", "Value" },
                values: new object[,]
                {
                    { 1457, "MNG", "Country:alpha-2", "MN" },
                    { 1503, "MOZ", "Country:sub-region-code", "202" },
                    { 1505, "MMR", "Country:name", "Myanmar" },
                    { 1506, "MMR", "Country:alpha-2", "MM" },
                    { 1507, "MMR", "Country:alpha-3", "MMR" },
                    { 1508, "MMR", "Country:country-code", "104" },
                    { 1509, "MMR", "Country:iso_3166-2", "ISO 3166-2:MM" },
                    { 1510, "MMR", "Country:region", "Asia" },
                    { 1511, "MMR", "Country:sub-region", "South-eastern Asia" },
                    { 1504, "MOZ", "Country:intermediate-region-code", "014" },
                    { 1837, "SHN", "Country:iso_3166-2", "ISO 3166-2:SH" },
                    { 1456, "MNG", "Country:name", "Mongolia" },
                    { 1454, "MCO", "Country:region-code", "150" },
                    { 1400, "MUS", "Country:iso_3166-2", "ISO 3166-2:MU" },
                    { 1401, "MUS", "Country:region", "Africa" },
                    { 1402, "MUS", "Country:sub-region", "Sub-Saharan Africa" },
                    { 1403, "MUS", "Country:intermediate-region", "Eastern Africa" },
                    { 1404, "MUS", "Country:region-code", "002" },
                    { 1405, "MUS", "Country:sub-region-code", "202" },
                    { 1406, "MUS", "Country:intermediate-region-code", "014" },
                    { 1407, "MYT", "Country:name", "Mayotte" },
                    { 1408, "MYT", "Country:alpha-2", "YT" },
                    { 1409, "MYT", "Country:alpha-3", "MYT" },
                    { 1410, "MYT", "Country:country-code", "175" },
                    { 1411, "MYT", "Country:iso_3166-2", "ISO 3166-2:YT" },
                    { 1412, "MYT", "Country:region", "Africa" },
                    { 1413, "MYT", "Country:sub-region", "Sub-Saharan Africa" },
                    { 1414, "MYT", "Country:intermediate-region", "Eastern Africa" },
                    { 1399, "MUS", "Country:country-code", "480" },
                    { 1415, "MYT", "Country:region-code", "002" },
                    { 1398, "MUS", "Country:alpha-3", "MUS" },
                    { 1396, "MUS", "Country:name", "Mauritius" },
                    { 1381, "MTQ", "Country:intermediate-region", "Caribbean" },
                    { 1382, "MTQ", "Country:region-code", "019" },
                    { 1383, "MTQ", "Country:sub-region-code", "419" },
                    { 1384, "MTQ", "Country:intermediate-region-code", "029" },
                    { 1385, "MRT", "Country:name", "Mauritania" },
                    { 1386, "MRT", "Country:alpha-2", "MR" },
                    { 1387, "MRT", "Country:alpha-3", "MRT" },
                    { 1388, "MRT", "Country:country-code", "478" },
                    { 1389, "MRT", "Country:iso_3166-2", "ISO 3166-2:MR" },
                    { 1390, "MRT", "Country:region", "Africa" },
                    { 1391, "MRT", "Country:sub-region", "Sub-Saharan Africa" },
                    { 1392, "MRT", "Country:intermediate-region", "Western Africa" },
                    { 1393, "MRT", "Country:region-code", "002" },
                    { 1394, "MRT", "Country:sub-region-code", "202" },
                    { 1395, "MRT", "Country:intermediate-region-code", "011" },
                    { 1397, "MUS", "Country:alpha-2", "MU" },
                    { 1416, "MYT", "Country:sub-region-code", "202" },
                    { 1417, "MYT", "Country:intermediate-region-code", "014" },
                    { 1418, "MEX", "Country:name", "Mexico" },
                    { 1439, "MDA", "Country:alpha-2", "MD" },
                    { 1440, "MDA", "Country:alpha-3", "MDA" },
                    { 1441, "MDA", "Country:country-code", "498" },
                    { 1442, "MDA", "Country:iso_3166-2", "ISO 3166-2:MD" },
                    { 1443, "MDA", "Country:region", "Europe" },
                    { 1444, "MDA", "Country:sub-region", "Eastern Europe" },
                    { 1445, "MDA", "Country:region-code", "150" },
                    { 1446, "MDA", "Country:sub-region-code", "151" },
                    { 1447, "MCO", "Country:name", "Monaco" },
                    { 1448, "MCO", "Country:alpha-2", "MC" },
                    { 1449, "MCO", "Country:alpha-3", "MCO" },
                    { 1450, "MCO", "Country:country-code", "492" },
                    { 1451, "MCO", "Country:iso_3166-2", "ISO 3166-2:MC" },
                    { 1452, "MCO", "Country:region", "Europe" },
                    { 1453, "MCO", "Country:sub-region", "Western Europe" },
                    { 1438, "MDA", "Country:name", "Moldova" },
                    { 1437, "FSM", "Country:sub-region-code", "057" },
                    { 1436, "FSM", "Country:region-code", "009" },
                    { 1435, "FSM", "Country:sub-region", "Micronesia" },
                    { 1419, "MEX", "Country:alpha-2", "MX" },
                    { 1420, "MEX", "Country:alpha-3", "MEX" },
                    { 1421, "MEX", "Country:country-code", "484" },
                    { 1422, "MEX", "Country:iso_3166-2", "ISO 3166-2:MX" },
                    { 1423, "MEX", "Country:region", "Americas" },
                    { 1424, "MEX", "Country:sub-region", "Latin America and the Caribbean" },
                    { 1425, "MEX", "Country:intermediate-region", "Central America" },
                    { 1455, "MCO", "Country:sub-region-code", "155" },
                    { 1426, "MEX", "Country:region-code", "019" },
                    { 1428, "MEX", "Country:intermediate-region-code", "013" },
                    { 1429, "FSM", "Country:name", "Micronesia (Federated States of)" },
                    { 1430, "FSM", "Country:alpha-2", "FM" },
                    { 1431, "FSM", "Country:alpha-3", "FSM" },
                    { 1432, "FSM", "Country:country-code", "583" },
                    { 1433, "FSM", "Country:iso_3166-2", "ISO 3166-2:FM" },
                    { 1434, "FSM", "Country:region", "Oceania" },
                    { 1427, "MEX", "Country:sub-region-code", "419" },
                    { 1227, "LVA", "Country:region-code", "150" },
                    { 1838, "SHN", "Country:region", "Africa" },
                    { 1840, "SHN", "Country:intermediate-region", "Western Africa" },
                    { 2244, "TUR", "Country:sub-region", "Western Asia" },
                    { 2245, "TUR", "Country:region-code", "142" },
                    { 2246, "TUR", "Country:sub-region-code", "145" },
                    { 2247, "TKM", "Country:name", "Turkmenistan" },
                    { 2248, "TKM", "Country:alpha-2", "TM" },
                    { 2249, "TKM", "Country:alpha-3", "TKM" },
                    { 2250, "TKM", "Country:country-code", "795" },
                    { 2251, "TKM", "Country:iso_3166-2", "ISO 3166-2:TM" },
                    { 2252, "TKM", "Country:region", "Asia" },
                    { 2253, "TKM", "Country:sub-region", "Central Asia" },
                    { 2254, "TKM", "Country:region-code", "142" },
                    { 2255, "TKM", "Country:sub-region-code", "143" },
                    { 2256, "TCA", "Country:name", "Turks and Caicos Islands" },
                    { 2257, "TCA", "Country:alpha-2", "TC" },
                    { 2258, "TCA", "Country:alpha-3", "TCA" },
                    { 2243, "TUR", "Country:region", "Asia" },
                    { 2259, "TCA", "Country:country-code", "796" },
                    { 2242, "TUR", "Country:iso_3166-2", "ISO 3166-2:TR" },
                    { 2240, "TUR", "Country:alpha-3", "TUR" },
                    { 2225, "TTO", "Country:intermediate-region", "Caribbean" },
                    { 2226, "TTO", "Country:region-code", "019" },
                    { 2227, "TTO", "Country:sub-region-code", "419" },
                    { 2228, "TTO", "Country:intermediate-region-code", "029" },
                    { 2229, "TUN", "Country:name", "Tunisia" },
                    { 2230, "TUN", "Country:alpha-2", "TN" },
                    { 2231, "TUN", "Country:alpha-3", "TUN" },
                    { 2232, "TUN", "Country:country-code", "788" },
                    { 2233, "TUN", "Country:iso_3166-2", "ISO 3166-2:TN" },
                    { 2234, "TUN", "Country:region", "Africa" },
                    { 2235, "TUN", "Country:sub-region", "Northern Africa" },
                    { 2236, "TUN", "Country:region-code", "002" },
                    { 2237, "TUN", "Country:sub-region-code", "015" },
                    { 2238, "TUR", "Country:name", "Turkey" },
                    { 2239, "TUR", "Country:alpha-2", "TR" },
                    { 2241, "TUR", "Country:country-code", "792" },
                    { 2224, "TTO", "Country:sub-region", "Latin America and the Caribbean" },
                    { 2260, "TCA", "Country:iso_3166-2", "ISO 3166-2:TC" },
                    { 2262, "TCA", "Country:sub-region", "Latin America and the Caribbean" },
                    { 2282, "UGA", "Country:sub-region", "Sub-Saharan Africa" },
                    { 2283, "UGA", "Country:intermediate-region", "Eastern Africa" },
                    { 2284, "UGA", "Country:region-code", "002" },
                    { 2285, "UGA", "Country:sub-region-code", "202" },
                    { 2286, "UGA", "Country:intermediate-region-code", "014" },
                    { 2287, "UKR", "Country:name", "Ukraine" },
                    { 2288, "UKR", "Country:alpha-2", "UA" },
                    { 2289, "UKR", "Country:alpha-3", "UKR" },
                    { 2290, "UKR", "Country:country-code", "804" },
                    { 2291, "UKR", "Country:iso_3166-2", "ISO 3166-2:UA" },
                    { 2292, "UKR", "Country:region", "Europe" },
                    { 2293, "UKR", "Country:sub-region", "Eastern Europe" },
                    { 2294, "UKR", "Country:region-code", "150" },
                    { 2295, "UKR", "Country:sub-region-code", "151" },
                    { 2296, "ARE", "Country:name", "United Arab Emirates" },
                    { 2281, "UGA", "Country:region", "Africa" },
                    { 2261, "TCA", "Country:region", "Americas" },
                    { 2280, "UGA", "Country:iso_3166-2", "ISO 3166-2:UG" },
                    { 2278, "UGA", "Country:alpha-3", "UGA" },
                    { 2263, "TCA", "Country:intermediate-region", "Caribbean" },
                    { 2264, "TCA", "Country:region-code", "019" },
                    { 2265, "TCA", "Country:sub-region-code", "419" },
                    { 2266, "TCA", "Country:intermediate-region-code", "029" },
                    { 2267, "TUV", "Country:name", "Tuvalu" },
                    { 2268, "TUV", "Country:alpha-2", "TV" },
                    { 2269, "TUV", "Country:alpha-3", "TUV" },
                    { 2270, "TUV", "Country:country-code", "798" },
                    { 2271, "TUV", "Country:iso_3166-2", "ISO 3166-2:TV" },
                    { 2272, "TUV", "Country:region", "Oceania" },
                    { 2273, "TUV", "Country:sub-region", "Polynesia" },
                    { 2274, "TUV", "Country:region-code", "009" },
                    { 2275, "TUV", "Country:sub-region-code", "061" },
                    { 2276, "UGA", "Country:name", "Uganda" },
                    { 2277, "UGA", "Country:alpha-2", "UG" },
                    { 2279, "UGA", "Country:country-code", "800" },
                    { 2223, "TTO", "Country:region", "Americas" },
                    { 2222, "TTO", "Country:iso_3166-2", "ISO 3166-2:TT" },
                    { 2221, "TTO", "Country:country-code", "780" },
                    { 2167, "TZA", "Country:intermediate-region", "Eastern Africa" },
                    { 2168, "TZA", "Country:region-code", "002" },
                    { 2169, "TZA", "Country:sub-region-code", "202" },
                    { 2170, "TZA", "Country:intermediate-region-code", "014" },
                    { 2171, "THA", "Country:name", "Thailand" },
                    { 2172, "THA", "Country:alpha-2", "TH" },
                    { 2173, "THA", "Country:alpha-3", "THA" },
                    { 2174, "THA", "Country:country-code", "764" },
                    { 2175, "THA", "Country:iso_3166-2", "ISO 3166-2:TH" },
                    { 2176, "THA", "Country:region", "Asia" },
                    { 2177, "THA", "Country:sub-region", "South-eastern Asia" },
                    { 2178, "THA", "Country:region-code", "142" },
                    { 2179, "THA", "Country:sub-region-code", "035" },
                    { 2180, "TLS", "Country:name", "Timor-Leste" },
                    { 2181, "TLS", "Country:alpha-2", "TL" },
                    { 2166, "TZA", "Country:sub-region", "Sub-Saharan Africa" },
                    { 2182, "TLS", "Country:alpha-3", "TLS" },
                    { 2165, "TZA", "Country:region", "Africa" },
                    { 2163, "TZA", "Country:country-code", "834" },
                    { 2148, "TWN", "Country:sub-region", "Eastern Asia" },
                    { 2149, "TWN", "Country:region-code", "142" },
                    { 2150, "TWN", "Country:sub-region-code", "030" },
                    { 2151, "TJK", "Country:name", "Tajikistan" },
                    { 2152, "TJK", "Country:alpha-2", "TJ" },
                    { 2153, "TJK", "Country:alpha-3", "TJK" },
                    { 2154, "TJK", "Country:country-code", "762" },
                    { 2155, "TJK", "Country:iso_3166-2", "ISO 3166-2:TJ" },
                    { 2156, "TJK", "Country:region", "Asia" },
                    { 2157, "TJK", "Country:sub-region", "Central Asia" },
                    { 2158, "TJK", "Country:region-code", "142" },
                    { 2159, "TJK", "Country:sub-region-code", "143" },
                    { 2160, "TZA", "Country:name", "Tanzania" },
                    { 2161, "TZA", "Country:alpha-2", "TZ" },
                    { 2162, "TZA", "Country:alpha-3", "TZA" },
                    { 2164, "TZA", "Country:iso_3166-2", "ISO 3166-2:TZ" },
                    { 2183, "TLS", "Country:country-code", "626" },
                    { 2184, "TLS", "Country:iso_3166-2", "ISO 3166-2:TL" },
                    { 2185, "TLS", "Country:region", "Asia" },
                    { 2206, "TKL", "Country:sub-region", "Polynesia" },
                    { 2207, "TKL", "Country:region-code", "009" },
                    { 2208, "TKL", "Country:sub-region-code", "061" },
                    { 2209, "TON", "Country:name", "Tonga" },
                    { 2210, "TON", "Country:alpha-2", "TO" },
                    { 2211, "TON", "Country:alpha-3", "TON" },
                    { 2212, "TON", "Country:country-code", "776" },
                    { 2213, "TON", "Country:iso_3166-2", "ISO 3166-2:TO" },
                    { 2214, "TON", "Country:region", "Oceania" },
                    { 2215, "TON", "Country:sub-region", "Polynesia" },
                    { 2216, "TON", "Country:region-code", "009" },
                    { 2217, "TON", "Country:sub-region-code", "061" },
                    { 2218, "TTO", "Country:name", "Trinidad and Tobago" },
                    { 2219, "TTO", "Country:alpha-2", "TT" },
                    { 2220, "TTO", "Country:alpha-3", "TTO" },
                    { 2205, "TKL", "Country:region", "Oceania" },
                    { 2204, "TKL", "Country:iso_3166-2", "ISO 3166-2:TK" },
                    { 2203, "TKL", "Country:country-code", "772" },
                    { 2202, "TKL", "Country:alpha-3", "TKL" },
                    { 2186, "TLS", "Country:sub-region", "South-eastern Asia" },
                    { 2187, "TLS", "Country:region-code", "142" },
                    { 2188, "TLS", "Country:sub-region-code", "035" },
                    { 2189, "TGO", "Country:name", "Togo" },
                    { 2190, "TGO", "Country:alpha-2", "TG" },
                    { 2191, "TGO", "Country:alpha-3", "TGO" },
                    { 2192, "TGO", "Country:country-code", "768" },
                    { 2297, "ARE", "Country:alpha-2", "AE" },
                    { 2193, "TGO", "Country:iso_3166-2", "ISO 3166-2:TG" },
                    { 2195, "TGO", "Country:sub-region", "Sub-Saharan Africa" },
                    { 2196, "TGO", "Country:intermediate-region", "Western Africa" },
                    { 2197, "TGO", "Country:region-code", "002" },
                    { 2198, "TGO", "Country:sub-region-code", "202" },
                    { 2199, "TGO", "Country:intermediate-region-code", "011" },
                    { 2200, "TKL", "Country:name", "Tokelau" },
                    { 2201, "TKL", "Country:alpha-2", "TK" },
                    { 2194, "TGO", "Country:region", "Africa" },
                    { 2147, "TWN", "Country:region", "Asia" },
                    { 2298, "ARE", "Country:alpha-3", "ARE" },
                    { 2300, "ARE", "Country:iso_3166-2", "ISO 3166-2:AE" },
                    { 2397, "VIR", "Country:region", "Americas" },
                    { 2398, "VIR", "Country:sub-region", "Latin America and the Caribbean" },
                    { 2399, "VIR", "Country:intermediate-region", "Caribbean" },
                    { 2400, "VIR", "Country:region-code", "019" },
                    { 2401, "VIR", "Country:sub-region-code", "419" },
                    { 2402, "VIR", "Country:intermediate-region-code", "029" },
                    { 2403, "WLF", "Country:name", "Wallis and Futuna" },
                    { 2404, "WLF", "Country:alpha-2", "WF" },
                    { 2405, "WLF", "Country:alpha-3", "WLF" },
                    { 2406, "WLF", "Country:country-code", "876" },
                    { 2407, "WLF", "Country:iso_3166-2", "ISO 3166-2:WF" },
                    { 2408, "WLF", "Country:region", "Oceania" },
                    { 2409, "WLF", "Country:sub-region", "Polynesia" },
                    { 2410, "WLF", "Country:region-code", "009" },
                    { 2411, "WLF", "Country:sub-region-code", "061" },
                    { 2396, "VIR", "Country:iso_3166-2", "ISO 3166-2:VI" },
                    { 2412, "ESH", "Country:name", "Western Sahara" },
                    { 2395, "VIR", "Country:country-code", "850" },
                    { 2393, "VIR", "Country:alpha-2", "VI" },
                    { 2378, "VNM", "Country:sub-region", "South-eastern Asia" },
                    { 2379, "VNM", "Country:region-code", "142" },
                    { 2380, "VNM", "Country:sub-region-code", "035" },
                    { 2381, "VGB", "Country:name", "Virgin Islands (British)" },
                    { 2382, "VGB", "Country:alpha-2", "VG" },
                    { 2383, "VGB", "Country:alpha-3", "VGB" },
                    { 2384, "VGB", "Country:country-code", "092" },
                    { 2385, "VGB", "Country:iso_3166-2", "ISO 3166-2:VG" },
                    { 2386, "VGB", "Country:region", "Americas" },
                    { 2387, "VGB", "Country:sub-region", "Latin America and the Caribbean" },
                    { 2388, "VGB", "Country:intermediate-region", "Caribbean" },
                    { 2389, "VGB", "Country:region-code", "019" },
                    { 2390, "VGB", "Country:sub-region-code", "419" },
                    { 2391, "VGB", "Country:intermediate-region-code", "029" },
                    { 2392, "VIR", "Country:name", "Virgin Islands (U.S.)" },
                    { 2394, "VIR", "Country:alpha-3", "VIR" },
                    { 2377, "VNM", "Country:region", "Asia" },
                    { 2413, "ESH", "Country:alpha-2", "EH" },
                    { 2415, "ESH", "Country:country-code", "732" },
                    { 2435, "ZMB", "Country:region", "Africa" },
                    { 2436, "ZMB", "Country:sub-region", "Sub-Saharan Africa" },
                    { 2437, "ZMB", "Country:intermediate-region", "Eastern Africa" },
                    { 2438, "ZMB", "Country:region-code", "002" },
                    { 2439, "ZMB", "Country:sub-region-code", "202" },
                    { 2440, "ZMB", "Country:intermediate-region-code", "014" },
                    { 2441, "ZWE", "Country:name", "Zimbabwe" },
                    { 2442, "ZWE", "Country:alpha-2", "ZW" },
                    { 2443, "ZWE", "Country:alpha-3", "ZWE" },
                    { 2444, "ZWE", "Country:country-code", "716" },
                    { 2445, "ZWE", "Country:iso_3166-2", "ISO 3166-2:ZW" },
                    { 2446, "ZWE", "Country:region", "Africa" },
                    { 2447, "ZWE", "Country:sub-region", "Sub-Saharan Africa" },
                    { 2448, "ZWE", "Country:intermediate-region", "Eastern Africa" },
                    { 2449, "ZWE", "Country:region-code", "002" },
                    { 2434, "ZMB", "Country:iso_3166-2", "ISO 3166-2:ZM" },
                    { 2414, "ESH", "Country:alpha-3", "ESH" },
                    { 2433, "ZMB", "Country:country-code", "894" },
                    { 2431, "ZMB", "Country:alpha-2", "ZM" },
                    { 2416, "ESH", "Country:iso_3166-2", "ISO 3166-2:EH" },
                    { 2417, "ESH", "Country:region", "Africa" },
                    { 2418, "ESH", "Country:sub-region", "Northern Africa" },
                    { 2419, "ESH", "Country:region-code", "002" },
                    { 2420, "ESH", "Country:sub-region-code", "015" },
                    { 2421, "YEM", "Country:name", "Yemen" },
                    { 2422, "YEM", "Country:alpha-2", "YE" },
                    { 2423, "YEM", "Country:alpha-3", "YEM" },
                    { 2424, "YEM", "Country:country-code", "887" },
                    { 2425, "YEM", "Country:iso_3166-2", "ISO 3166-2:YE" },
                    { 2426, "YEM", "Country:region", "Asia" },
                    { 2427, "YEM", "Country:sub-region", "Western Asia" },
                    { 2428, "YEM", "Country:region-code", "142" },
                    { 2429, "YEM", "Country:sub-region-code", "145" },
                    { 2430, "ZMB", "Country:name", "Zambia" },
                    { 2432, "ZMB", "Country:alpha-3", "ZMB" },
                    { 2376, "VNM", "Country:iso_3166-2", "ISO 3166-2:VN" },
                    { 2375, "VNM", "Country:country-code", "704" },
                    { 2374, "VNM", "Country:alpha-3", "VNM" },
                    { 2320, "USA", "Country:sub-region", "Northern America" },
                    { 2321, "USA", "Country:region-code", "019" },
                    { 2322, "USA", "Country:sub-region-code", "021" },
                    { 2323, "UMI", "Country:name", "United States Minor Outlying Islands" },
                    { 2324, "UMI", "Country:alpha-2", "UM" },
                    { 2325, "UMI", "Country:alpha-3", "UMI" },
                    { 2326, "UMI", "Country:country-code", "581" },
                    { 2327, "UMI", "Country:iso_3166-2", "ISO 3166-2:UM" },
                    { 2328, "UMI", "Country:region", "Oceania" },
                    { 2329, "UMI", "Country:sub-region", "Micronesia" },
                    { 2330, "UMI", "Country:region-code", "009" },
                    { 2331, "UMI", "Country:sub-region-code", "057" },
                    { 2332, "URY", "Country:name", "Uruguay" },
                    { 2333, "URY", "Country:alpha-2", "UY" },
                    { 2334, "URY", "Country:alpha-3", "URY" },
                    { 2319, "USA", "Country:region", "Americas" },
                    { 2335, "URY", "Country:country-code", "858" },
                    { 2318, "USA", "Country:iso_3166-2", "ISO 3166-2:US" },
                    { 2316, "USA", "Country:alpha-3", "USA" },
                    { 2301, "ARE", "Country:region", "Asia" },
                    { 2302, "ARE", "Country:sub-region", "Western Asia" },
                    { 2303, "ARE", "Country:region-code", "142" },
                    { 2304, "ARE", "Country:sub-region-code", "145" },
                    { 2305, "GBR", "Country:name", "United Kingdom of Great Britain and Northern Ireland" },
                    { 2306, "GBR", "Country:alpha-2", "GB" },
                    { 2307, "GBR", "Country:alpha-3", "GBR" },
                    { 2308, "GBR", "Country:country-code", "826" },
                    { 2309, "GBR", "Country:iso_3166-2", "ISO 3166-2:GB" },
                    { 2310, "GBR", "Country:region", "Europe" },
                    { 2311, "GBR", "Country:sub-region", "Northern Europe" },
                    { 2312, "GBR", "Country:region-code", "150" },
                    { 2313, "GBR", "Country:sub-region-code", "154" },
                    { 2314, "USA", "Country:name", "United States of America" },
                    { 2315, "USA", "Country:alpha-2", "US" },
                    { 2317, "USA", "Country:country-code", "840" },
                    { 2336, "URY", "Country:iso_3166-2", "ISO 3166-2:UY" },
                    { 2337, "URY", "Country:region", "Americas" },
                    { 2338, "URY", "Country:sub-region", "Latin America and the Caribbean" },
                    { 2359, "VUT", "Country:region-code", "009" },
                    { 2360, "VUT", "Country:sub-region-code", "054" },
                    { 2361, "VEN", "Country:name", "Venezuela (Bolivarian Republic of)" },
                    { 2362, "VEN", "Country:alpha-2", "VE" },
                    { 2363, "VEN", "Country:alpha-3", "VEN" },
                    { 2364, "VEN", "Country:country-code", "862" },
                    { 2365, "VEN", "Country:iso_3166-2", "ISO 3166-2:VE" },
                    { 2366, "VEN", "Country:region", "Americas" },
                    { 2367, "VEN", "Country:sub-region", "Latin America and the Caribbean" },
                    { 2368, "VEN", "Country:intermediate-region", "South America" },
                    { 2369, "VEN", "Country:region-code", "019" },
                    { 2370, "VEN", "Country:sub-region-code", "419" },
                    { 2371, "VEN", "Country:intermediate-region-code", "005" },
                    { 2372, "VNM", "Country:name", "Viet Nam" },
                    { 2373, "VNM", "Country:alpha-2", "VN" },
                    { 2358, "VUT", "Country:sub-region", "Melanesia" },
                    { 2357, "VUT", "Country:region", "Oceania" },
                    { 2356, "VUT", "Country:iso_3166-2", "ISO 3166-2:VU" },
                    { 2355, "VUT", "Country:country-code", "548" },
                    { 2339, "URY", "Country:intermediate-region", "South America" },
                    { 2340, "URY", "Country:region-code", "019" },
                    { 2341, "URY", "Country:sub-region-code", "419" },
                    { 2342, "URY", "Country:intermediate-region-code", "005" },
                    { 2343, "UZB", "Country:name", "Uzbekistan" },
                    { 2344, "UZB", "Country:alpha-2", "UZ" },
                    { 2345, "UZB", "Country:alpha-3", "UZB" },
                    { 2299, "ARE", "Country:country-code", "784" },
                    { 2346, "UZB", "Country:country-code", "860" },
                    { 2348, "UZB", "Country:region", "Asia" },
                    { 2349, "UZB", "Country:sub-region", "Central Asia" },
                    { 2350, "UZB", "Country:region-code", "142" },
                    { 2351, "UZB", "Country:sub-region-code", "143" },
                    { 2352, "VUT", "Country:name", "Vanuatu" },
                    { 2353, "VUT", "Country:alpha-2", "VU" },
                    { 2354, "VUT", "Country:alpha-3", "VUT" },
                    { 2347, "UZB", "Country:iso_3166-2", "ISO 3166-2:UZ" },
                    { 2146, "TWN", "Country:iso_3166-2", "ISO 3166-2:TW" },
                    { 2145, "TWN", "Country:country-code", "158" },
                    { 2144, "TWN", "Country:alpha-3", "TWN" },
                    { 1937, "SEN", "Country:alpha-3", "SEN" },
                    { 1938, "SEN", "Country:country-code", "686" },
                    { 1939, "SEN", "Country:iso_3166-2", "ISO 3166-2:SN" },
                    { 1940, "SEN", "Country:region", "Africa" },
                    { 1941, "SEN", "Country:sub-region", "Sub-Saharan Africa" },
                    { 1942, "SEN", "Country:intermediate-region", "Western Africa" },
                    { 1943, "SEN", "Country:region-code", "002" },
                    { 1944, "SEN", "Country:sub-region-code", "202" },
                    { 1945, "SEN", "Country:intermediate-region-code", "011" },
                    { 1946, "SRB", "Country:name", "Serbia" },
                    { 1947, "SRB", "Country:alpha-2", "RS" },
                    { 1948, "SRB", "Country:alpha-3", "SRB" },
                    { 1949, "SRB", "Country:country-code", "688" },
                    { 1950, "SRB", "Country:iso_3166-2", "ISO 3166-2:RS" },
                    { 1951, "SRB", "Country:region", "Europe" },
                    { 1936, "SEN", "Country:alpha-2", "SN" },
                    { 1952, "SRB", "Country:sub-region", "Southern Europe" },
                    { 1935, "SEN", "Country:name", "Senegal" },
                    { 1933, "SAU", "Country:region-code", "142" },
                    { 1918, "STP", "Country:country-code", "678" },
                    { 1919, "STP", "Country:iso_3166-2", "ISO 3166-2:ST" },
                    { 1920, "STP", "Country:region", "Africa" },
                    { 1921, "STP", "Country:sub-region", "Sub-Saharan Africa" },
                    { 1922, "STP", "Country:intermediate-region", "Middle Africa" },
                    { 1923, "STP", "Country:region-code", "002" },
                    { 1924, "STP", "Country:sub-region-code", "202" },
                    { 1925, "STP", "Country:intermediate-region-code", "017" },
                    { 1926, "SAU", "Country:name", "Saudi Arabia" },
                    { 1927, "SAU", "Country:alpha-2", "SA" },
                    { 1928, "SAU", "Country:alpha-3", "SAU" },
                    { 1929, "SAU", "Country:country-code", "682" },
                    { 1930, "SAU", "Country:iso_3166-2", "ISO 3166-2:SA" },
                    { 1931, "SAU", "Country:region", "Asia" },
                    { 1932, "SAU", "Country:sub-region", "Western Asia" },
                    { 1934, "SAU", "Country:sub-region-code", "145" },
                    { 1917, "STP", "Country:alpha-3", "STP" },
                    { 1953, "SRB", "Country:region-code", "150" },
                    { 1955, "SYC", "Country:name", "Seychelles" },
                    { 1975, "SLE", "Country:sub-region-code", "202" },
                    { 1976, "SLE", "Country:intermediate-region-code", "011" },
                    { 1977, "SGP", "Country:name", "Singapore" },
                    { 1978, "SGP", "Country:alpha-2", "SG" },
                    { 1979, "SGP", "Country:alpha-3", "SGP" },
                    { 1980, "SGP", "Country:country-code", "702" },
                    { 1981, "SGP", "Country:iso_3166-2", "ISO 3166-2:SG" },
                    { 1982, "SGP", "Country:region", "Asia" },
                    { 1983, "SGP", "Country:sub-region", "South-eastern Asia" },
                    { 1984, "SGP", "Country:region-code", "142" },
                    { 1985, "SGP", "Country:sub-region-code", "035" },
                    { 1986, "SXM", "Country:name", "Sint Maarten (Dutch part)" },
                    { 1987, "SXM", "Country:alpha-2", "SX" },
                    { 1988, "SXM", "Country:alpha-3", "SXM" },
                    { 1989, "SXM", "Country:country-code", "534" },
                    { 1974, "SLE", "Country:region-code", "002" },
                    { 1954, "SRB", "Country:sub-region-code", "039" },
                    { 1973, "SLE", "Country:intermediate-region", "Western Africa" },
                    { 1971, "SLE", "Country:region", "Africa" },
                    { 1956, "SYC", "Country:alpha-2", "SC" },
                    { 1957, "SYC", "Country:alpha-3", "SYC" },
                    { 1958, "SYC", "Country:country-code", "690" },
                    { 1959, "SYC", "Country:iso_3166-2", "ISO 3166-2:SC" },
                    { 1960, "SYC", "Country:region", "Africa" },
                    { 1961, "SYC", "Country:sub-region", "Sub-Saharan Africa" },
                    { 1962, "SYC", "Country:intermediate-region", "Eastern Africa" },
                    { 1963, "SYC", "Country:region-code", "002" },
                    { 1964, "SYC", "Country:sub-region-code", "202" },
                    { 1965, "SYC", "Country:intermediate-region-code", "014" },
                    { 1966, "SLE", "Country:name", "Sierra Leone" },
                    { 1967, "SLE", "Country:alpha-2", "SL" },
                    { 1968, "SLE", "Country:alpha-3", "SLE" },
                    { 1969, "SLE", "Country:country-code", "694" },
                    { 1970, "SLE", "Country:iso_3166-2", "ISO 3166-2:SL" },
                    { 1972, "SLE", "Country:sub-region", "Sub-Saharan Africa" },
                    { 1916, "STP", "Country:alpha-2", "ST" },
                    { 1915, "STP", "Country:name", "Sao Tome and Principe" },
                    { 1914, "SMR", "Country:sub-region-code", "039" },
                    { 1860, "LCA", "Country:region", "Americas" },
                    { 1861, "LCA", "Country:sub-region", "Latin America and the Caribbean" },
                    { 1862, "LCA", "Country:intermediate-region", "Caribbean" },
                    { 1863, "LCA", "Country:region-code", "019" },
                    { 1864, "LCA", "Country:sub-region-code", "419" },
                    { 1865, "LCA", "Country:intermediate-region-code", "029" },
                    { 1866, "MAF", "Country:name", "Saint Martin (French part)" },
                    { 1867, "MAF", "Country:alpha-2", "MF" },
                    { 1868, "MAF", "Country:alpha-3", "MAF" },
                    { 1869, "MAF", "Country:country-code", "663" },
                    { 1870, "MAF", "Country:iso_3166-2", "ISO 3166-2:MF" },
                    { 1871, "MAF", "Country:region", "Americas" },
                    { 1872, "MAF", "Country:sub-region", "Latin America and the Caribbean" },
                    { 1873, "MAF", "Country:intermediate-region", "Caribbean" },
                    { 1874, "MAF", "Country:region-code", "019" },
                    { 1859, "LCA", "Country:iso_3166-2", "ISO 3166-2:LC" },
                    { 1875, "MAF", "Country:sub-region-code", "419" },
                    { 1858, "LCA", "Country:country-code", "662" },
                    { 1856, "LCA", "Country:alpha-2", "LC" },
                    { 1841, "SHN", "Country:region-code", "002" },
                    { 1842, "SHN", "Country:sub-region-code", "202" },
                    { 1843, "SHN", "Country:intermediate-region-code", "011" },
                    { 1844, "KNA", "Country:name", "Saint Kitts and Nevis" },
                    { 1845, "KNA", "Country:alpha-2", "KN" },
                    { 1846, "KNA", "Country:alpha-3", "KNA" },
                    { 1847, "KNA", "Country:country-code", "659" },
                    { 1848, "KNA", "Country:iso_3166-2", "ISO 3166-2:KN" },
                    { 1849, "KNA", "Country:region", "Americas" },
                    { 1850, "KNA", "Country:sub-region", "Latin America and the Caribbean" },
                    { 1851, "KNA", "Country:intermediate-region", "Caribbean" },
                    { 1852, "KNA", "Country:region-code", "019" },
                    { 1853, "KNA", "Country:sub-region-code", "419" },
                    { 1854, "KNA", "Country:intermediate-region-code", "029" },
                    { 1855, "LCA", "Country:name", "Saint Lucia" },
                    { 1857, "LCA", "Country:alpha-3", "LCA" },
                    { 1876, "MAF", "Country:intermediate-region-code", "029" },
                    { 1877, "SPM", "Country:name", "Saint Pierre and Miquelon" },
                    { 1878, "SPM", "Country:alpha-2", "PM" },
                    { 1899, "WSM", "Country:alpha-3", "WSM" },
                    { 1900, "WSM", "Country:country-code", "882" },
                    { 1901, "WSM", "Country:iso_3166-2", "ISO 3166-2:WS" },
                    { 1902, "WSM", "Country:region", "Oceania" },
                    { 1903, "WSM", "Country:sub-region", "Polynesia" },
                    { 1904, "WSM", "Country:region-code", "009" },
                    { 1905, "WSM", "Country:sub-region-code", "061" },
                    { 1906, "SMR", "Country:name", "San Marino" },
                    { 1907, "SMR", "Country:alpha-2", "SM" },
                    { 1908, "SMR", "Country:alpha-3", "SMR" },
                    { 1909, "SMR", "Country:country-code", "674" },
                    { 1910, "SMR", "Country:iso_3166-2", "ISO 3166-2:SM" },
                    { 1911, "SMR", "Country:region", "Europe" },
                    { 1912, "SMR", "Country:sub-region", "Southern Europe" }
                });

            migrationBuilder.InsertData(
                table: "ReferenceDataItems",
                columns: new[] { "ID", "Key", "Path", "Value" },
                values: new object[,]
                {
                    { 1913, "SMR", "Country:region-code", "150" },
                    { 1898, "WSM", "Country:alpha-2", "WS" },
                    { 1897, "WSM", "Country:name", "Samoa" },
                    { 1896, "VCT", "Country:intermediate-region-code", "029" },
                    { 1895, "VCT", "Country:sub-region-code", "419" },
                    { 1879, "SPM", "Country:alpha-3", "SPM" },
                    { 1880, "SPM", "Country:country-code", "666" },
                    { 1881, "SPM", "Country:iso_3166-2", "ISO 3166-2:PM" },
                    { 1882, "SPM", "Country:region", "Americas" },
                    { 1883, "SPM", "Country:sub-region", "Northern America" },
                    { 1884, "SPM", "Country:region-code", "019" },
                    { 1885, "SPM", "Country:sub-region-code", "021" },
                    { 1990, "SXM", "Country:iso_3166-2", "ISO 3166-2:SX" },
                    { 1886, "VCT", "Country:name", "Saint Vincent and the Grenadines" },
                    { 1888, "VCT", "Country:alpha-3", "VCT" },
                    { 1889, "VCT", "Country:country-code", "670" },
                    { 1890, "VCT", "Country:iso_3166-2", "ISO 3166-2:VC" },
                    { 1891, "VCT", "Country:region", "Americas" },
                    { 1892, "VCT", "Country:sub-region", "Latin America and the Caribbean" },
                    { 1893, "VCT", "Country:intermediate-region", "Caribbean" },
                    { 1894, "VCT", "Country:region-code", "019" },
                    { 1887, "VCT", "Country:alpha-2", "VC" },
                    { 1991, "SXM", "Country:region", "Americas" },
                    { 1992, "SXM", "Country:sub-region", "Latin America and the Caribbean" },
                    { 1993, "SXM", "Country:intermediate-region", "Caribbean" },
                    { 2090, "SDN", "Country:iso_3166-2", "ISO 3166-2:SD" },
                    { 2091, "SDN", "Country:region", "Africa" },
                    { 2092, "SDN", "Country:sub-region", "Northern Africa" },
                    { 2093, "SDN", "Country:region-code", "002" },
                    { 2094, "SDN", "Country:sub-region-code", "015" },
                    { 2095, "SUR", "Country:name", "Suriname" },
                    { 2096, "SUR", "Country:alpha-2", "SR" },
                    { 2097, "SUR", "Country:alpha-3", "SUR" },
                    { 2098, "SUR", "Country:country-code", "740" },
                    { 2099, "SUR", "Country:iso_3166-2", "ISO 3166-2:SR" },
                    { 2100, "SUR", "Country:region", "Americas" },
                    { 2101, "SUR", "Country:sub-region", "Latin America and the Caribbean" },
                    { 2102, "SUR", "Country:intermediate-region", "South America" },
                    { 2103, "SUR", "Country:region-code", "019" },
                    { 2104, "SUR", "Country:sub-region-code", "419" },
                    { 2089, "SDN", "Country:country-code", "729" },
                    { 2105, "SUR", "Country:intermediate-region-code", "005" },
                    { 2088, "SDN", "Country:alpha-3", "SDN" },
                    { 2086, "SDN", "Country:name", "Sudan" },
                    { 2071, "ESP", "Country:country-code", "724" },
                    { 2072, "ESP", "Country:iso_3166-2", "ISO 3166-2:ES" },
                    { 2073, "ESP", "Country:region", "Europe" },
                    { 2074, "ESP", "Country:sub-region", "Southern Europe" },
                    { 2075, "ESP", "Country:region-code", "150" },
                    { 2076, "ESP", "Country:sub-region-code", "039" },
                    { 2077, "LKA", "Country:name", "Sri Lanka" },
                    { 2078, "LKA", "Country:alpha-2", "LK" },
                    { 2079, "LKA", "Country:alpha-3", "LKA" },
                    { 2080, "LKA", "Country:country-code", "144" },
                    { 2081, "LKA", "Country:iso_3166-2", "ISO 3166-2:LK" },
                    { 2082, "LKA", "Country:region", "Asia" },
                    { 2083, "LKA", "Country:sub-region", "Southern Asia" },
                    { 2084, "LKA", "Country:region-code", "142" },
                    { 2085, "LKA", "Country:sub-region-code", "034" },
                    { 2087, "SDN", "Country:alpha-2", "SD" },
                    { 2106, "SJM", "Country:name", "Svalbard and Jan Mayen" },
                    { 2107, "SJM", "Country:alpha-2", "SJ" },
                    { 2108, "SJM", "Country:alpha-3", "SJM" },
                    { 2129, "CHE", "Country:region", "Europe" },
                    { 2130, "CHE", "Country:sub-region", "Western Europe" },
                    { 2131, "CHE", "Country:region-code", "150" },
                    { 2132, "CHE", "Country:sub-region-code", "155" },
                    { 2133, "SYR", "Country:name", "Syrian Arab Republic" },
                    { 2134, "SYR", "Country:alpha-2", "SY" },
                    { 2135, "SYR", "Country:alpha-3", "SYR" },
                    { 2136, "SYR", "Country:country-code", "760" },
                    { 2137, "SYR", "Country:iso_3166-2", "ISO 3166-2:SY" },
                    { 2138, "SYR", "Country:region", "Asia" },
                    { 2139, "SYR", "Country:sub-region", "Western Asia" },
                    { 2140, "SYR", "Country:region-code", "142" },
                    { 2141, "SYR", "Country:sub-region-code", "145" },
                    { 2142, "TWN", "Country:name", "Taiwan" },
                    { 2143, "TWN", "Country:alpha-2", "TW" },
                    { 2128, "CHE", "Country:iso_3166-2", "ISO 3166-2:CH" },
                    { 2127, "CHE", "Country:country-code", "756" },
                    { 2126, "CHE", "Country:alpha-3", "CHE" },
                    { 2125, "CHE", "Country:alpha-2", "CH" },
                    { 2109, "SJM", "Country:country-code", "744" },
                    { 2110, "SJM", "Country:iso_3166-2", "ISO 3166-2:SJ" },
                    { 2111, "SJM", "Country:region", "Europe" },
                    { 2112, "SJM", "Country:sub-region", "Northern Europe" },
                    { 2113, "SJM", "Country:region-code", "150" },
                    { 2114, "SJM", "Country:sub-region-code", "154" },
                    { 2115, "SWE", "Country:name", "Sweden" },
                    { 2070, "ESP", "Country:alpha-3", "ESP" },
                    { 2116, "SWE", "Country:alpha-2", "SE" },
                    { 2118, "SWE", "Country:country-code", "752" },
                    { 2119, "SWE", "Country:iso_3166-2", "ISO 3166-2:SE" },
                    { 2120, "SWE", "Country:region", "Europe" },
                    { 2121, "SWE", "Country:sub-region", "Northern Europe" },
                    { 2122, "SWE", "Country:region-code", "150" },
                    { 2123, "SWE", "Country:sub-region-code", "154" },
                    { 2124, "CHE", "Country:name", "Switzerland" },
                    { 2117, "SWE", "Country:alpha-3", "SWE" },
                    { 1839, "SHN", "Country:sub-region", "Sub-Saharan Africa" },
                    { 2069, "ESP", "Country:alpha-2", "ES" },
                    { 2067, "SSD", "Country:intermediate-region-code", "014" },
                    { 2013, "SVN", "Country:region-code", "150" },
                    { 2014, "SVN", "Country:sub-region-code", "039" },
                    { 2015, "SLB", "Country:name", "Solomon Islands" },
                    { 2016, "SLB", "Country:alpha-2", "SB" },
                    { 2017, "SLB", "Country:alpha-3", "SLB" },
                    { 2018, "SLB", "Country:country-code", "090" },
                    { 2019, "SLB", "Country:iso_3166-2", "ISO 3166-2:SB" },
                    { 2020, "SLB", "Country:region", "Oceania" },
                    { 2021, "SLB", "Country:sub-region", "Melanesia" },
                    { 2022, "SLB", "Country:region-code", "009" },
                    { 2023, "SLB", "Country:sub-region-code", "054" },
                    { 2024, "SOM", "Country:name", "Somalia" },
                    { 2025, "SOM", "Country:alpha-2", "SO" },
                    { 2026, "SOM", "Country:alpha-3", "SOM" },
                    { 2027, "SOM", "Country:country-code", "706" },
                    { 2012, "SVN", "Country:sub-region", "Southern Europe" },
                    { 2028, "SOM", "Country:iso_3166-2", "ISO 3166-2:SO" },
                    { 2011, "SVN", "Country:region", "Europe" },
                    { 2009, "SVN", "Country:country-code", "705" },
                    { 1994, "SXM", "Country:region-code", "019" },
                    { 1995, "SXM", "Country:sub-region-code", "419" },
                    { 1996, "SXM", "Country:intermediate-region-code", "029" },
                    { 1997, "SVK", "Country:name", "Slovakia" },
                    { 1998, "SVK", "Country:alpha-2", "SK" },
                    { 1999, "SVK", "Country:alpha-3", "SVK" },
                    { 2000, "SVK", "Country:country-code", "703" },
                    { 2001, "SVK", "Country:iso_3166-2", "ISO 3166-2:SK" },
                    { 2002, "SVK", "Country:region", "Europe" },
                    { 2003, "SVK", "Country:sub-region", "Eastern Europe" },
                    { 2004, "SVK", "Country:region-code", "150" },
                    { 2005, "SVK", "Country:sub-region-code", "151" },
                    { 2006, "SVN", "Country:name", "Slovenia" },
                    { 2007, "SVN", "Country:alpha-2", "SI" },
                    { 2008, "SVN", "Country:alpha-3", "SVN" },
                    { 2010, "SVN", "Country:iso_3166-2", "ISO 3166-2:SI" },
                    { 2029, "SOM", "Country:region", "Africa" },
                    { 2030, "SOM", "Country:sub-region", "Sub-Saharan Africa" },
                    { 2031, "SOM", "Country:intermediate-region", "Eastern Africa" },
                    { 2052, "SGS", "Country:sub-region", "Latin America and the Caribbean" },
                    { 2053, "SGS", "Country:intermediate-region", "South America" },
                    { 2054, "SGS", "Country:region-code", "019" },
                    { 2055, "SGS", "Country:sub-region-code", "419" },
                    { 2056, "SGS", "Country:intermediate-region-code", "005" },
                    { 2057, "SSD", "Country:name", "South Sudan" },
                    { 2058, "SSD", "Country:alpha-2", "SS" },
                    { 2059, "SSD", "Country:alpha-3", "SSD" },
                    { 2060, "SSD", "Country:country-code", "728" },
                    { 2061, "SSD", "Country:iso_3166-2", "ISO 3166-2:SS" },
                    { 2062, "SSD", "Country:region", "Africa" },
                    { 2063, "SSD", "Country:sub-region", "Sub-Saharan Africa" },
                    { 2064, "SSD", "Country:intermediate-region", "Eastern Africa" },
                    { 2065, "SSD", "Country:region-code", "002" },
                    { 2066, "SSD", "Country:sub-region-code", "202" },
                    { 2051, "SGS", "Country:region", "Americas" },
                    { 2050, "SGS", "Country:iso_3166-2", "ISO 3166-2:GS" },
                    { 2049, "SGS", "Country:country-code", "239" },
                    { 2048, "SGS", "Country:alpha-3", "SGS" },
                    { 2032, "SOM", "Country:region-code", "002" },
                    { 2033, "SOM", "Country:sub-region-code", "202" },
                    { 2034, "SOM", "Country:intermediate-region-code", "014" },
                    { 2035, "ZAF", "Country:name", "South Africa" },
                    { 2036, "ZAF", "Country:alpha-2", "ZA" },
                    { 2037, "ZAF", "Country:alpha-3", "ZAF" },
                    { 2038, "ZAF", "Country:country-code", "710" },
                    { 2068, "ESP", "Country:name", "Spain" },
                    { 2039, "ZAF", "Country:iso_3166-2", "ISO 3166-2:ZA" },
                    { 2041, "ZAF", "Country:sub-region", "Sub-Saharan Africa" },
                    { 2042, "ZAF", "Country:intermediate-region", "Southern Africa" },
                    { 2043, "ZAF", "Country:region-code", "002" },
                    { 2044, "ZAF", "Country:sub-region-code", "202" },
                    { 2045, "ZAF", "Country:intermediate-region-code", "018" },
                    { 2046, "SGS", "Country:name", "South Georgia and the South Sandwich Islands" },
                    { 2047, "SGS", "Country:alpha-2", "GS" },
                    { 2040, "ZAF", "Country:region", "Africa" },
                    { 2450, "ZWE", "Country:sub-region-code", "202" },
                    { 1226, "LVA", "Country:sub-region", "Northern Europe" },
                    { 1224, "LVA", "Country:iso_3166-2", "ISO 3166-2:LV" },
                    { 405, "CYM", "Country:alpha-2", "KY" },
                    { 406, "CYM", "Country:alpha-3", "CYM" },
                    { 407, "CYM", "Country:country-code", "136" },
                    { 408, "CYM", "Country:iso_3166-2", "ISO 3166-2:KY" },
                    { 409, "CYM", "Country:region", "Americas" },
                    { 410, "CYM", "Country:sub-region", "Latin America and the Caribbean" },
                    { 411, "CYM", "Country:intermediate-region", "Caribbean" },
                    { 412, "CYM", "Country:region-code", "019" },
                    { 413, "CYM", "Country:sub-region-code", "419" },
                    { 414, "CYM", "Country:intermediate-region-code", "029" },
                    { 415, "CAF", "Country:name", "Central African Republic" },
                    { 416, "CAF", "Country:alpha-2", "CF" },
                    { 417, "CAF", "Country:alpha-3", "CAF" },
                    { 418, "CAF", "Country:country-code", "140" },
                    { 419, "CAF", "Country:iso_3166-2", "ISO 3166-2:CF" },
                    { 404, "CYM", "Country:name", "Cayman Islands" },
                    { 420, "CAF", "Country:region", "Africa" },
                    { 403, "CAN", "Country:sub-region-code", "021" },
                    { 401, "CAN", "Country:sub-region", "Northern America" },
                    { 386, "CMR", "Country:alpha-3", "CMR" },
                    { 387, "CMR", "Country:country-code", "120" },
                    { 388, "CMR", "Country:iso_3166-2", "ISO 3166-2:CM" },
                    { 389, "CMR", "Country:region", "Africa" },
                    { 390, "CMR", "Country:sub-region", "Sub-Saharan Africa" },
                    { 391, "CMR", "Country:intermediate-region", "Middle Africa" },
                    { 392, "CMR", "Country:region-code", "002" },
                    { 393, "CMR", "Country:sub-region-code", "202" },
                    { 394, "CMR", "Country:intermediate-region-code", "017" },
                    { 395, "CAN", "Country:name", "Canada" },
                    { 396, "CAN", "Country:alpha-2", "CA" },
                    { 397, "CAN", "Country:alpha-3", "CAN" },
                    { 398, "CAN", "Country:country-code", "124" },
                    { 399, "CAN", "Country:iso_3166-2", "ISO 3166-2:CA" },
                    { 400, "CAN", "Country:region", "Americas" },
                    { 402, "CAN", "Country:region-code", "019" },
                    { 385, "CMR", "Country:alpha-2", "CM" },
                    { 421, "CAF", "Country:sub-region", "Sub-Saharan Africa" },
                    { 423, "CAF", "Country:region-code", "002" },
                    { 443, "CHL", "Country:sub-region", "Latin America and the Caribbean" },
                    { 444, "CHL", "Country:intermediate-region", "South America" },
                    { 445, "CHL", "Country:region-code", "019" },
                    { 446, "CHL", "Country:sub-region-code", "419" },
                    { 447, "CHL", "Country:intermediate-region-code", "005" },
                    { 448, "CHN", "Country:name", "China" },
                    { 449, "CHN", "Country:alpha-2", "CN" },
                    { 450, "CHN", "Country:alpha-3", "CHN" },
                    { 451, "CHN", "Country:country-code", "156" },
                    { 452, "CHN", "Country:iso_3166-2", "ISO 3166-2:CN" },
                    { 453, "CHN", "Country:region", "Asia" },
                    { 454, "CHN", "Country:sub-region", "Eastern Asia" },
                    { 455, "CHN", "Country:region-code", "142" },
                    { 456, "CHN", "Country:sub-region-code", "030" },
                    { 457, "CXR", "Country:name", "Christmas Island" },
                    { 442, "CHL", "Country:region", "Americas" },
                    { 422, "CAF", "Country:intermediate-region", "Middle Africa" },
                    { 441, "CHL", "Country:iso_3166-2", "ISO 3166-2:CL" },
                    { 439, "CHL", "Country:alpha-3", "CHL" },
                    { 424, "CAF", "Country:sub-region-code", "202" },
                    { 425, "CAF", "Country:intermediate-region-code", "017" },
                    { 426, "TCD", "Country:name", "Chad" },
                    { 427, "TCD", "Country:alpha-2", "TD" },
                    { 428, "TCD", "Country:alpha-3", "TCD" },
                    { 429, "TCD", "Country:country-code", "148" },
                    { 430, "TCD", "Country:iso_3166-2", "ISO 3166-2:TD" },
                    { 431, "TCD", "Country:region", "Africa" },
                    { 432, "TCD", "Country:sub-region", "Sub-Saharan Africa" },
                    { 433, "TCD", "Country:intermediate-region", "Middle Africa" },
                    { 434, "TCD", "Country:region-code", "002" },
                    { 435, "TCD", "Country:sub-region-code", "202" },
                    { 436, "TCD", "Country:intermediate-region-code", "017" },
                    { 437, "CHL", "Country:name", "Chile" },
                    { 438, "CHL", "Country:alpha-2", "CL" },
                    { 440, "CHL", "Country:country-code", "152" },
                    { 384, "CMR", "Country:name", "Cameroon" },
                    { 383, "KHM", "Country:sub-region-code", "035" },
                    { 382, "KHM", "Country:region-code", "142" },
                    { 328, "BRN", "Country:iso_3166-2", "ISO 3166-2:BN" },
                    { 329, "BRN", "Country:region", "Asia" },
                    { 330, "BRN", "Country:sub-region", "South-eastern Asia" },
                    { 331, "BRN", "Country:region-code", "142" },
                    { 332, "BRN", "Country:sub-region-code", "035" },
                    { 333, "BGR", "Country:name", "Bulgaria" },
                    { 334, "BGR", "Country:alpha-2", "BG" },
                    { 335, "BGR", "Country:alpha-3", "BGR" },
                    { 336, "BGR", "Country:country-code", "100" },
                    { 337, "BGR", "Country:iso_3166-2", "ISO 3166-2:BG" },
                    { 338, "BGR", "Country:region", "Europe" },
                    { 339, "BGR", "Country:sub-region", "Eastern Europe" },
                    { 340, "BGR", "Country:region-code", "150" },
                    { 341, "BGR", "Country:sub-region-code", "151" },
                    { 342, "BFA", "Country:name", "Burkina Faso" },
                    { 327, "BRN", "Country:country-code", "096" },
                    { 343, "BFA", "Country:alpha-2", "BF" },
                    { 326, "BRN", "Country:alpha-3", "BRN" },
                    { 324, "BRN", "Country:name", "Brunei Darussalam" },
                    { 309, "BRA", "Country:intermediate-region", "South America" },
                    { 310, "BRA", "Country:region-code", "019" },
                    { 311, "BRA", "Country:sub-region-code", "419" },
                    { 312, "BRA", "Country:intermediate-region-code", "005" },
                    { 313, "IOT", "Country:name", "British Indian Ocean Territory" },
                    { 314, "IOT", "Country:alpha-2", "IO" },
                    { 315, "IOT", "Country:alpha-3", "IOT" },
                    { 316, "IOT", "Country:country-code", "086" },
                    { 317, "IOT", "Country:iso_3166-2", "ISO 3166-2:IO" },
                    { 318, "IOT", "Country:region", "Africa" },
                    { 319, "IOT", "Country:sub-region", "Sub-Saharan Africa" },
                    { 320, "IOT", "Country:intermediate-region", "Eastern Africa" },
                    { 321, "IOT", "Country:region-code", "002" },
                    { 322, "IOT", "Country:sub-region-code", "202" },
                    { 323, "IOT", "Country:intermediate-region-code", "014" },
                    { 325, "BRN", "Country:alpha-2", "BN" },
                    { 344, "BFA", "Country:alpha-3", "BFA" },
                    { 345, "BFA", "Country:country-code", "854" },
                    { 346, "BFA", "Country:iso_3166-2", "ISO 3166-2:BF" },
                    { 367, "CPV", "Country:country-code", "132" },
                    { 368, "CPV", "Country:iso_3166-2", "ISO 3166-2:CV" },
                    { 369, "CPV", "Country:region", "Africa" },
                    { 370, "CPV", "Country:sub-region", "Sub-Saharan Africa" },
                    { 371, "CPV", "Country:intermediate-region", "Western Africa" },
                    { 372, "CPV", "Country:region-code", "002" },
                    { 373, "CPV", "Country:sub-region-code", "202" },
                    { 374, "CPV", "Country:intermediate-region-code", "011" },
                    { 375, "KHM", "Country:name", "Cambodia" },
                    { 376, "KHM", "Country:alpha-2", "KH" },
                    { 377, "KHM", "Country:alpha-3", "KHM" },
                    { 378, "KHM", "Country:country-code", "116" },
                    { 379, "KHM", "Country:iso_3166-2", "ISO 3166-2:KH" },
                    { 380, "KHM", "Country:region", "Asia" },
                    { 381, "KHM", "Country:sub-region", "South-eastern Asia" },
                    { 366, "CPV", "Country:alpha-3", "CPV" },
                    { 365, "CPV", "Country:alpha-2", "CV" },
                    { 364, "CPV", "Country:name", "Cabo Verde" },
                    { 363, "BDI", "Country:intermediate-region-code", "014" },
                    { 347, "BFA", "Country:region", "Africa" },
                    { 348, "BFA", "Country:sub-region", "Sub-Saharan Africa" },
                    { 349, "BFA", "Country:intermediate-region", "Western Africa" },
                    { 350, "BFA", "Country:region-code", "002" },
                    { 351, "BFA", "Country:sub-region-code", "202" },
                    { 352, "BFA", "Country:intermediate-region-code", "011" },
                    { 353, "BDI", "Country:name", "Burundi" },
                    { 458, "CXR", "Country:alpha-2", "CX" },
                    { 354, "BDI", "Country:alpha-2", "BI" },
                    { 356, "BDI", "Country:country-code", "108" },
                    { 357, "BDI", "Country:iso_3166-2", "ISO 3166-2:BI" },
                    { 358, "BDI", "Country:region", "Africa" },
                    { 359, "BDI", "Country:sub-region", "Sub-Saharan Africa" },
                    { 360, "BDI", "Country:intermediate-region", "Eastern Africa" },
                    { 361, "BDI", "Country:region-code", "002" },
                    { 362, "BDI", "Country:sub-region-code", "202" },
                    { 355, "BDI", "Country:alpha-3", "BDI" },
                    { 308, "BRA", "Country:sub-region", "Latin America and the Caribbean" },
                    { 459, "CXR", "Country:alpha-3", "CXR" },
                    { 461, "CXR", "Country:iso_3166-2", "ISO 3166-2:CX" },
                    { 558, "HRV", "Country:sub-region-code", "039" },
                    { 559, "CUB", "Country:name", "Cuba" },
                    { 560, "CUB", "Country:alpha-2", "CU" },
                    { 561, "CUB", "Country:alpha-3", "CUB" },
                    { 562, "CUB", "Country:country-code", "192" },
                    { 563, "CUB", "Country:iso_3166-2", "ISO 3166-2:CU" },
                    { 564, "CUB", "Country:region", "Americas" },
                    { 565, "CUB", "Country:sub-region", "Latin America and the Caribbean" },
                    { 566, "CUB", "Country:intermediate-region", "Caribbean" },
                    { 567, "CUB", "Country:region-code", "019" },
                    { 568, "CUB", "Country:sub-region-code", "419" },
                    { 569, "CUB", "Country:intermediate-region-code", "029" },
                    { 570, "CUW", "Country:name", "Curaçao" },
                    { 571, "CUW", "Country:alpha-2", "CW" },
                    { 572, "CUW", "Country:alpha-3", "CUW" },
                    { 557, "HRV", "Country:region-code", "150" },
                    { 573, "CUW", "Country:country-code", "531" },
                    { 556, "HRV", "Country:sub-region", "Southern Europe" },
                    { 554, "HRV", "Country:iso_3166-2", "ISO 3166-2:HR" },
                    { 539, "CIV", "Country:name", "Côte d'Ivoire" },
                    { 540, "CIV", "Country:alpha-2", "CI" },
                    { 541, "CIV", "Country:alpha-3", "CIV" },
                    { 542, "CIV", "Country:country-code", "384" },
                    { 543, "CIV", "Country:iso_3166-2", "ISO 3166-2:CI" },
                    { 544, "CIV", "Country:region", "Africa" },
                    { 545, "CIV", "Country:sub-region", "Sub-Saharan Africa" },
                    { 546, "CIV", "Country:intermediate-region", "Western Africa" },
                    { 547, "CIV", "Country:region-code", "002" },
                    { 548, "CIV", "Country:sub-region-code", "202" },
                    { 549, "CIV", "Country:intermediate-region-code", "011" },
                    { 550, "HRV", "Country:name", "Croatia" },
                    { 551, "HRV", "Country:alpha-2", "HR" },
                    { 552, "HRV", "Country:alpha-3", "HRV" },
                    { 553, "HRV", "Country:country-code", "191" },
                    { 555, "HRV", "Country:region", "Europe" },
                    { 538, "CRI", "Country:intermediate-region-code", "013" },
                    { 574, "CUW", "Country:iso_3166-2", "ISO 3166-2:CW" },
                    { 576, "CUW", "Country:sub-region", "Latin America and the Caribbean" },
                    { 596, "CZE", "Country:sub-region", "Eastern Europe" },
                    { 597, "CZE", "Country:region-code", "150" },
                    { 598, "CZE", "Country:sub-region-code", "151" },
                    { 599, "DNK", "Country:name", "Denmark" },
                    { 600, "DNK", "Country:alpha-2", "DK" },
                    { 601, "DNK", "Country:alpha-3", "DNK" },
                    { 602, "DNK", "Country:country-code", "208" },
                    { 603, "DNK", "Country:iso_3166-2", "ISO 3166-2:DK" },
                    { 604, "DNK", "Country:region", "Europe" },
                    { 605, "DNK", "Country:sub-region", "Northern Europe" },
                    { 606, "DNK", "Country:region-code", "150" },
                    { 607, "DNK", "Country:sub-region-code", "154" },
                    { 608, "DJI", "Country:name", "Djibouti" },
                    { 609, "DJI", "Country:alpha-2", "DJ" },
                    { 610, "DJI", "Country:alpha-3", "DJI" },
                    { 595, "CZE", "Country:region", "Europe" },
                    { 575, "CUW", "Country:region", "Americas" },
                    { 594, "CZE", "Country:iso_3166-2", "ISO 3166-2:CZ" },
                    { 592, "CZE", "Country:alpha-3", "CZE" },
                    { 577, "CUW", "Country:intermediate-region", "Caribbean" },
                    { 578, "CUW", "Country:region-code", "019" },
                    { 579, "CUW", "Country:sub-region-code", "419" },
                    { 580, "CUW", "Country:intermediate-region-code", "029" },
                    { 581, "CYP", "Country:name", "Cyprus" },
                    { 582, "CYP", "Country:alpha-2", "CY" },
                    { 583, "CYP", "Country:alpha-3", "CYP" },
                    { 584, "CYP", "Country:country-code", "196" },
                    { 585, "CYP", "Country:iso_3166-2", "ISO 3166-2:CY" },
                    { 586, "CYP", "Country:region", "Asia" },
                    { 587, "CYP", "Country:sub-region", "Western Asia" },
                    { 588, "CYP", "Country:region-code", "142" },
                    { 589, "CYP", "Country:sub-region-code", "145" },
                    { 590, "CZE", "Country:name", "Czechia" },
                    { 591, "CZE", "Country:alpha-2", "CZ" },
                    { 593, "CZE", "Country:country-code", "203" },
                    { 537, "CRI", "Country:sub-region-code", "419" },
                    { 536, "CRI", "Country:region-code", "019" },
                    { 535, "CRI", "Country:intermediate-region", "Central America" },
                    { 481, "COL", "Country:sub-region", "Latin America and the Caribbean" },
                    { 482, "COL", "Country:intermediate-region", "South America" },
                    { 483, "COL", "Country:region-code", "019" },
                    { 484, "COL", "Country:sub-region-code", "419" },
                    { 485, "COL", "Country:intermediate-region-code", "005" },
                    { 486, "COM", "Country:name", "Comoros" },
                    { 487, "COM", "Country:alpha-2", "KM" },
                    { 488, "COM", "Country:alpha-3", "COM" },
                    { 489, "COM", "Country:country-code", "174" },
                    { 490, "COM", "Country:iso_3166-2", "ISO 3166-2:KM" },
                    { 491, "COM", "Country:region", "Africa" },
                    { 492, "COM", "Country:sub-region", "Sub-Saharan Africa" },
                    { 493, "COM", "Country:intermediate-region", "Eastern Africa" },
                    { 494, "COM", "Country:region-code", "002" },
                    { 495, "COM", "Country:sub-region-code", "202" },
                    { 480, "COL", "Country:region", "Americas" },
                    { 496, "COM", "Country:intermediate-region-code", "014" },
                    { 479, "COL", "Country:iso_3166-2", "ISO 3166-2:CO" },
                    { 477, "COL", "Country:alpha-3", "COL" },
                    { 462, "CXR", "Country:region", "Oceania" },
                    { 463, "CXR", "Country:sub-region", "Australia and New Zealand" },
                    { 464, "CXR", "Country:region-code", "009" },
                    { 465, "CXR", "Country:sub-region-code", "053" },
                    { 466, "CCK", "Country:name", "Cocos (Keeling) Islands" },
                    { 467, "CCK", "Country:alpha-2", "CC" },
                    { 468, "CCK", "Country:alpha-3", "CCK" },
                    { 469, "CCK", "Country:country-code", "166" },
                    { 470, "CCK", "Country:iso_3166-2", "ISO 3166-2:CC" },
                    { 471, "CCK", "Country:region", "Oceania" },
                    { 472, "CCK", "Country:sub-region", "Australia and New Zealand" },
                    { 473, "CCK", "Country:region-code", "009" },
                    { 474, "CCK", "Country:sub-region-code", "053" },
                    { 475, "COL", "Country:name", "Colombia" },
                    { 476, "COL", "Country:alpha-2", "CO" },
                    { 478, "COL", "Country:country-code", "170" },
                    { 497, "COG", "Country:name", "Congo" },
                    { 498, "COG", "Country:alpha-2", "CG" },
                    { 499, "COG", "Country:alpha-3", "COG" },
                    { 520, "COK", "Country:alpha-2", "CK" },
                    { 521, "COK", "Country:alpha-3", "COK" },
                    { 522, "COK", "Country:country-code", "184" },
                    { 523, "COK", "Country:iso_3166-2", "ISO 3166-2:CK" },
                    { 524, "COK", "Country:region", "Oceania" },
                    { 525, "COK", "Country:sub-region", "Polynesia" },
                    { 526, "COK", "Country:region-code", "009" },
                    { 527, "COK", "Country:sub-region-code", "061" },
                    { 528, "CRI", "Country:name", "Costa Rica" },
                    { 529, "CRI", "Country:alpha-2", "CR" },
                    { 530, "CRI", "Country:alpha-3", "CRI" },
                    { 531, "CRI", "Country:country-code", "188" },
                    { 532, "CRI", "Country:iso_3166-2", "ISO 3166-2:CR" },
                    { 533, "CRI", "Country:region", "Americas" },
                    { 534, "CRI", "Country:sub-region", "Latin America and the Caribbean" },
                    { 519, "COK", "Country:name", "Cook Islands" },
                    { 518, "COD", "Country:intermediate-region-code", "017" },
                    { 517, "COD", "Country:sub-region-code", "202" },
                    { 516, "COD", "Country:region-code", "002" },
                    { 500, "COG", "Country:country-code", "178" },
                    { 501, "COG", "Country:iso_3166-2", "ISO 3166-2:CG" },
                    { 502, "COG", "Country:region", "Africa" },
                    { 503, "COG", "Country:sub-region", "Sub-Saharan Africa" },
                    { 504, "COG", "Country:intermediate-region", "Middle Africa" },
                    { 505, "COG", "Country:region-code", "002" },
                    { 506, "COG", "Country:sub-region-code", "202" },
                    { 460, "CXR", "Country:country-code", "162" },
                    { 507, "COG", "Country:intermediate-region-code", "017" },
                    { 509, "COD", "Country:alpha-2", "CD" },
                    { 510, "COD", "Country:alpha-3", "COD" },
                    { 511, "COD", "Country:country-code", "180" },
                    { 512, "COD", "Country:iso_3166-2", "ISO 3166-2:CD" },
                    { 513, "COD", "Country:region", "Africa" },
                    { 514, "COD", "Country:sub-region", "Sub-Saharan Africa" },
                    { 515, "COD", "Country:intermediate-region", "Middle Africa" },
                    { 508, "COD", "Country:name", "Congo" },
                    { 307, "BRA", "Country:region", "Americas" },
                    { 306, "BRA", "Country:iso_3166-2", "ISO 3166-2:BR" },
                    { 305, "BRA", "Country:country-code", "076" },
                    { 98, "ARG", "Country:region", "Americas" },
                    { 99, "ARG", "Country:sub-region", "Latin America and the Caribbean" },
                    { 100, "ARG", "Country:intermediate-region", "South America" },
                    { 101, "ARG", "Country:region-code", "019" },
                    { 102, "ARG", "Country:sub-region-code", "419" },
                    { 103, "ARG", "Country:intermediate-region-code", "005" },
                    { 104, "ARM", "Country:name", "Armenia" },
                    { 105, "ARM", "Country:alpha-2", "AM" },
                    { 106, "ARM", "Country:alpha-3", "ARM" },
                    { 107, "ARM", "Country:country-code", "051" },
                    { 108, "ARM", "Country:iso_3166-2", "ISO 3166-2:AM" },
                    { 109, "ARM", "Country:region", "Asia" },
                    { 110, "ARM", "Country:sub-region", "Western Asia" },
                    { 111, "ARM", "Country:region-code", "142" },
                    { 112, "ARM", "Country:sub-region-code", "145" },
                    { 97, "ARG", "Country:iso_3166-2", "ISO 3166-2:AR" },
                    { 113, "ABW", "Country:name", "Aruba" },
                    { 96, "ARG", "Country:country-code", "032" },
                    { 94, "ARG", "Country:alpha-2", "AR" },
                    { 79, "ATA", "Country:alpha-3", "ATA" },
                    { 80, "ATA", "Country:country-code", "010" },
                    { 81, "ATA", "Country:iso_3166-2", "ISO 3166-2:AQ" },
                    { 82, "ATG", "Country:name", "Antigua and Barbuda" },
                    { 83, "ATG", "Country:alpha-2", "AG" },
                    { 84, "ATG", "Country:alpha-3", "ATG" },
                    { 85, "ATG", "Country:country-code", "028" },
                    { 86, "ATG", "Country:iso_3166-2", "ISO 3166-2:AG" },
                    { 87, "ATG", "Country:region", "Americas" },
                    { 88, "ATG", "Country:sub-region", "Latin America and the Caribbean" },
                    { 89, "ATG", "Country:intermediate-region", "Caribbean" },
                    { 90, "ATG", "Country:region-code", "019" },
                    { 91, "ATG", "Country:sub-region-code", "419" },
                    { 92, "ATG", "Country:intermediate-region-code", "029" },
                    { 93, "ARG", "Country:name", "Argentina" },
                    { 95, "ARG", "Country:alpha-3", "ARG" },
                    { 78, "ATA", "Country:alpha-2", "AQ" },
                    { 114, "ABW", "Country:alpha-2", "AW" },
                    { 116, "ABW", "Country:country-code", "533" },
                    { 136, "AUT", "Country:country-code", "040" }
                });

            migrationBuilder.InsertData(
                table: "ReferenceDataItems",
                columns: new[] { "ID", "Key", "Path", "Value" },
                values: new object[,]
                {
                    { 137, "AUT", "Country:iso_3166-2", "ISO 3166-2:AT" },
                    { 138, "AUT", "Country:region", "Europe" },
                    { 139, "AUT", "Country:sub-region", "Western Europe" },
                    { 140, "AUT", "Country:region-code", "150" },
                    { 141, "AUT", "Country:sub-region-code", "155" },
                    { 142, "AZE", "Country:name", "Azerbaijan" },
                    { 143, "AZE", "Country:alpha-2", "AZ" },
                    { 144, "AZE", "Country:alpha-3", "AZE" },
                    { 145, "AZE", "Country:country-code", "031" },
                    { 146, "AZE", "Country:iso_3166-2", "ISO 3166-2:AZ" },
                    { 147, "AZE", "Country:region", "Asia" },
                    { 148, "AZE", "Country:sub-region", "Western Asia" },
                    { 149, "AZE", "Country:region-code", "142" },
                    { 150, "AZE", "Country:sub-region-code", "145" },
                    { 135, "AUT", "Country:alpha-3", "AUT" },
                    { 115, "ABW", "Country:alpha-3", "ABW" },
                    { 134, "AUT", "Country:alpha-2", "AT" },
                    { 132, "AUS", "Country:sub-region-code", "053" },
                    { 117, "ABW", "Country:iso_3166-2", "ISO 3166-2:AW" },
                    { 118, "ABW", "Country:region", "Americas" },
                    { 119, "ABW", "Country:sub-region", "Latin America and the Caribbean" },
                    { 120, "ABW", "Country:intermediate-region", "Caribbean" },
                    { 121, "ABW", "Country:region-code", "019" },
                    { 122, "ABW", "Country:sub-region-code", "419" },
                    { 123, "ABW", "Country:intermediate-region-code", "029" },
                    { 124, "AUS", "Country:name", "Australia" },
                    { 125, "AUS", "Country:alpha-2", "AU" },
                    { 126, "AUS", "Country:alpha-3", "AUS" },
                    { 127, "AUS", "Country:country-code", "036" },
                    { 128, "AUS", "Country:iso_3166-2", "ISO 3166-2:AU" },
                    { 129, "AUS", "Country:region", "Oceania" },
                    { 130, "AUS", "Country:sub-region", "Australia and New Zealand" },
                    { 131, "AUS", "Country:region-code", "009" },
                    { 133, "AUT", "Country:name", "Austria" },
                    { 77, "ATA", "Country:name", "Antarctica" },
                    { 76, "AIA", "Country:intermediate-region-code", "029" },
                    { 75, "AIA", "Country:sub-region-code", "419" },
                    { 21, "ALB", "Country:alpha-3", "ALB" },
                    { 22, "ALB", "Country:country-code", "008" },
                    { 23, "ALB", "Country:iso_3166-2", "ISO 3166-2:AL" },
                    { 24, "ALB", "Country:region", "Europe" },
                    { 25, "ALB", "Country:sub-region", "Southern Europe" },
                    { 26, "ALB", "Country:region-code", "150" },
                    { 27, "ALB", "Country:sub-region-code", "039" },
                    { 28, "DZA", "Country:name", "Algeria" },
                    { 29, "DZA", "Country:alpha-2", "DZ" },
                    { 30, "DZA", "Country:alpha-3", "DZA" },
                    { 31, "DZA", "Country:country-code", "012" },
                    { 32, "DZA", "Country:iso_3166-2", "ISO 3166-2:DZ" },
                    { 33, "DZA", "Country:region", "Africa" },
                    { 34, "DZA", "Country:sub-region", "Northern Africa" },
                    { 35, "DZA", "Country:region-code", "002" },
                    { 20, "ALB", "Country:alpha-2", "AL" },
                    { 36, "DZA", "Country:sub-region-code", "015" },
                    { 19, "ALB", "Country:name", "Albania" },
                    { 17, "ALA", "Country:region-code", "150" },
                    { 2, "AFG", "Country:alpha-2", "AF" },
                    { 3, "AFG", "Country:alpha-3", "AFG" },
                    { 4, "AFG", "Country:country-code", "004" },
                    { 5, "AFG", "Country:iso_3166-2", "ISO 3166-2:AF" },
                    { 6, "AFG", "Country:region", "Asia" },
                    { 7, "AFG", "Country:sub-region", "Southern Asia" },
                    { 8, "AFG", "Country:region-code", "142" },
                    { 9, "AFG", "Country:sub-region-code", "034" },
                    { 10, "ALA", "Country:name", "Åland Islands" },
                    { 11, "ALA", "Country:alpha-2", "AX" },
                    { 12, "ALA", "Country:alpha-3", "ALA" },
                    { 13, "ALA", "Country:country-code", "248" },
                    { 14, "ALA", "Country:iso_3166-2", "ISO 3166-2:AX" },
                    { 15, "ALA", "Country:region", "Europe" },
                    { 16, "ALA", "Country:sub-region", "Northern Europe" },
                    { 18, "ALA", "Country:sub-region-code", "154" },
                    { 37, "ASM", "Country:name", "American Samoa" },
                    { 38, "ASM", "Country:alpha-2", "AS" },
                    { 39, "ASM", "Country:alpha-3", "ASM" },
                    { 60, "AGO", "Country:region", "Africa" },
                    { 61, "AGO", "Country:sub-region", "Sub-Saharan Africa" },
                    { 62, "AGO", "Country:intermediate-region", "Middle Africa" },
                    { 63, "AGO", "Country:region-code", "002" },
                    { 64, "AGO", "Country:sub-region-code", "202" },
                    { 65, "AGO", "Country:intermediate-region-code", "017" },
                    { 66, "AIA", "Country:name", "Anguilla" },
                    { 67, "AIA", "Country:alpha-2", "AI" },
                    { 68, "AIA", "Country:alpha-3", "AIA" },
                    { 69, "AIA", "Country:country-code", "660" },
                    { 70, "AIA", "Country:iso_3166-2", "ISO 3166-2:AI" },
                    { 71, "AIA", "Country:region", "Americas" },
                    { 72, "AIA", "Country:sub-region", "Latin America and the Caribbean" },
                    { 73, "AIA", "Country:intermediate-region", "Caribbean" },
                    { 74, "AIA", "Country:region-code", "019" },
                    { 59, "AGO", "Country:iso_3166-2", "ISO 3166-2:AO" },
                    { 58, "AGO", "Country:country-code", "024" },
                    { 57, "AGO", "Country:alpha-3", "AGO" },
                    { 56, "AGO", "Country:alpha-2", "AO" },
                    { 40, "ASM", "Country:country-code", "016" },
                    { 41, "ASM", "Country:iso_3166-2", "ISO 3166-2:AS" },
                    { 42, "ASM", "Country:region", "Oceania" },
                    { 43, "ASM", "Country:sub-region", "Polynesia" },
                    { 44, "ASM", "Country:region-code", "009" },
                    { 45, "ASM", "Country:sub-region-code", "061" },
                    { 46, "AND", "Country:name", "Andorra" },
                    { 151, "BHS", "Country:name", "Bahamas" },
                    { 47, "AND", "Country:alpha-2", "AD" },
                    { 49, "AND", "Country:country-code", "020" },
                    { 50, "AND", "Country:iso_3166-2", "ISO 3166-2:AD" },
                    { 51, "AND", "Country:region", "Europe" },
                    { 52, "AND", "Country:sub-region", "Southern Europe" },
                    { 53, "AND", "Country:region-code", "150" },
                    { 54, "AND", "Country:sub-region-code", "039" },
                    { 55, "AGO", "Country:name", "Angola" },
                    { 48, "AND", "Country:alpha-3", "AND" },
                    { 152, "BHS", "Country:alpha-2", "BS" },
                    { 153, "BHS", "Country:alpha-3", "BHS" },
                    { 154, "BHS", "Country:country-code", "044" },
                    { 251, "BOL", "Country:alpha-3", "BOL" },
                    { 252, "BOL", "Country:country-code", "068" },
                    { 253, "BOL", "Country:iso_3166-2", "ISO 3166-2:BO" },
                    { 254, "BOL", "Country:region", "Americas" },
                    { 255, "BOL", "Country:sub-region", "Latin America and the Caribbean" },
                    { 256, "BOL", "Country:intermediate-region", "South America" },
                    { 257, "BOL", "Country:region-code", "019" },
                    { 258, "BOL", "Country:sub-region-code", "419" },
                    { 259, "BOL", "Country:intermediate-region-code", "005" },
                    { 260, "BES", "Country:name", "Bonaire" },
                    { 261, "BES", "Country:alpha-2", "BQ" },
                    { 262, "BES", "Country:alpha-3", "BES" },
                    { 263, "BES", "Country:country-code", "535" },
                    { 264, "BES", "Country:iso_3166-2", "ISO 3166-2:BQ" },
                    { 265, "BES", "Country:region", "Americas" },
                    { 250, "BOL", "Country:alpha-2", "BO" },
                    { 266, "BES", "Country:sub-region", "Latin America and the Caribbean" },
                    { 249, "BOL", "Country:name", "Bolivia (Plurinational State of)" },
                    { 247, "BTN", "Country:region-code", "142" },
                    { 232, "BMU", "Country:alpha-2", "BM" },
                    { 233, "BMU", "Country:alpha-3", "BMU" },
                    { 234, "BMU", "Country:country-code", "060" },
                    { 235, "BMU", "Country:iso_3166-2", "ISO 3166-2:BM" },
                    { 236, "BMU", "Country:region", "Americas" },
                    { 237, "BMU", "Country:sub-region", "Northern America" },
                    { 238, "BMU", "Country:region-code", "019" },
                    { 239, "BMU", "Country:sub-region-code", "021" },
                    { 240, "BTN", "Country:name", "Bhutan" },
                    { 241, "BTN", "Country:alpha-2", "BT" },
                    { 242, "BTN", "Country:alpha-3", "BTN" },
                    { 243, "BTN", "Country:country-code", "064" },
                    { 244, "BTN", "Country:iso_3166-2", "ISO 3166-2:BT" },
                    { 245, "BTN", "Country:region", "Asia" },
                    { 246, "BTN", "Country:sub-region", "Southern Asia" },
                    { 248, "BTN", "Country:sub-region-code", "034" },
                    { 267, "BES", "Country:intermediate-region", "Caribbean" },
                    { 268, "BES", "Country:region-code", "019" },
                    { 269, "BES", "Country:sub-region-code", "419" },
                    { 290, "BWA", "Country:intermediate-region-code", "018" },
                    { 291, "BVT", "Country:name", "Bouvet Island" },
                    { 292, "BVT", "Country:alpha-2", "BV" },
                    { 293, "BVT", "Country:alpha-3", "BVT" },
                    { 294, "BVT", "Country:country-code", "074" },
                    { 295, "BVT", "Country:iso_3166-2", "ISO 3166-2:BV" },
                    { 296, "BVT", "Country:region", "Americas" },
                    { 297, "BVT", "Country:sub-region", "Latin America and the Caribbean" },
                    { 298, "BVT", "Country:intermediate-region", "South America" },
                    { 299, "BVT", "Country:region-code", "019" },
                    { 300, "BVT", "Country:sub-region-code", "419" },
                    { 301, "BVT", "Country:intermediate-region-code", "005" },
                    { 302, "BRA", "Country:name", "Brazil" },
                    { 303, "BRA", "Country:alpha-2", "BR" },
                    { 304, "BRA", "Country:alpha-3", "BRA" },
                    { 289, "BWA", "Country:sub-region-code", "202" },
                    { 288, "BWA", "Country:region-code", "002" },
                    { 287, "BWA", "Country:intermediate-region", "Southern Africa" },
                    { 286, "BWA", "Country:sub-region", "Sub-Saharan Africa" },
                    { 270, "BES", "Country:intermediate-region-code", "029" },
                    { 271, "BIH", "Country:name", "Bosnia and Herzegovina" },
                    { 272, "BIH", "Country:alpha-2", "BA" },
                    { 273, "BIH", "Country:alpha-3", "BIH" },
                    { 274, "BIH", "Country:country-code", "070" },
                    { 275, "BIH", "Country:iso_3166-2", "ISO 3166-2:BA" },
                    { 276, "BIH", "Country:region", "Europe" },
                    { 231, "BMU", "Country:name", "Bermuda" },
                    { 277, "BIH", "Country:sub-region", "Southern Europe" },
                    { 279, "BIH", "Country:sub-region-code", "039" },
                    { 280, "BWA", "Country:name", "Botswana" },
                    { 281, "BWA", "Country:alpha-2", "BW" },
                    { 282, "BWA", "Country:alpha-3", "BWA" },
                    { 283, "BWA", "Country:country-code", "072" },
                    { 284, "BWA", "Country:iso_3166-2", "ISO 3166-2:BW" },
                    { 285, "BWA", "Country:region", "Africa" },
                    { 278, "BIH", "Country:region-code", "150" },
                    { 611, "DJI", "Country:country-code", "262" },
                    { 230, "BEN", "Country:intermediate-region-code", "011" },
                    { 228, "BEN", "Country:region-code", "002" },
                    { 174, "BGD", "Country:country-code", "050" },
                    { 175, "BGD", "Country:iso_3166-2", "ISO 3166-2:BD" },
                    { 176, "BGD", "Country:region", "Asia" },
                    { 177, "BGD", "Country:sub-region", "Southern Asia" },
                    { 178, "BGD", "Country:region-code", "142" },
                    { 179, "BGD", "Country:sub-region-code", "034" },
                    { 180, "BRB", "Country:name", "Barbados" },
                    { 181, "BRB", "Country:alpha-2", "BB" },
                    { 182, "BRB", "Country:alpha-3", "BRB" },
                    { 183, "BRB", "Country:country-code", "052" },
                    { 184, "BRB", "Country:iso_3166-2", "ISO 3166-2:BB" },
                    { 185, "BRB", "Country:region", "Americas" },
                    { 186, "BRB", "Country:sub-region", "Latin America and the Caribbean" },
                    { 187, "BRB", "Country:intermediate-region", "Caribbean" },
                    { 188, "BRB", "Country:region-code", "019" },
                    { 173, "BGD", "Country:alpha-3", "BGD" },
                    { 189, "BRB", "Country:sub-region-code", "419" },
                    { 172, "BGD", "Country:alpha-2", "BD" },
                    { 170, "BHR", "Country:sub-region-code", "145" },
                    { 155, "BHS", "Country:iso_3166-2", "ISO 3166-2:BS" },
                    { 156, "BHS", "Country:region", "Americas" },
                    { 157, "BHS", "Country:sub-region", "Latin America and the Caribbean" },
                    { 158, "BHS", "Country:intermediate-region", "Caribbean" },
                    { 159, "BHS", "Country:region-code", "019" },
                    { 160, "BHS", "Country:sub-region-code", "419" },
                    { 161, "BHS", "Country:intermediate-region-code", "029" },
                    { 162, "BHR", "Country:name", "Bahrain" },
                    { 163, "BHR", "Country:alpha-2", "BH" },
                    { 164, "BHR", "Country:alpha-3", "BHR" },
                    { 165, "BHR", "Country:country-code", "048" },
                    { 166, "BHR", "Country:iso_3166-2", "ISO 3166-2:BH" },
                    { 167, "BHR", "Country:region", "Asia" },
                    { 168, "BHR", "Country:sub-region", "Western Asia" },
                    { 169, "BHR", "Country:region-code", "142" },
                    { 171, "BGD", "Country:name", "Bangladesh" },
                    { 190, "BRB", "Country:intermediate-region-code", "029" },
                    { 191, "BLR", "Country:name", "Belarus" },
                    { 192, "BLR", "Country:alpha-2", "BY" },
                    { 213, "BLZ", "Country:iso_3166-2", "ISO 3166-2:BZ" },
                    { 214, "BLZ", "Country:region", "Americas" },
                    { 215, "BLZ", "Country:sub-region", "Latin America and the Caribbean" },
                    { 216, "BLZ", "Country:intermediate-region", "Central America" },
                    { 217, "BLZ", "Country:region-code", "019" },
                    { 218, "BLZ", "Country:sub-region-code", "419" },
                    { 219, "BLZ", "Country:intermediate-region-code", "013" },
                    { 220, "BEN", "Country:name", "Benin" },
                    { 221, "BEN", "Country:alpha-2", "BJ" },
                    { 222, "BEN", "Country:alpha-3", "BEN" },
                    { 223, "BEN", "Country:country-code", "204" },
                    { 224, "BEN", "Country:iso_3166-2", "ISO 3166-2:BJ" },
                    { 225, "BEN", "Country:region", "Africa" },
                    { 226, "BEN", "Country:sub-region", "Sub-Saharan Africa" },
                    { 227, "BEN", "Country:intermediate-region", "Western Africa" },
                    { 212, "BLZ", "Country:country-code", "084" },
                    { 211, "BLZ", "Country:alpha-3", "BLZ" },
                    { 210, "BLZ", "Country:alpha-2", "BZ" },
                    { 209, "BLZ", "Country:name", "Belize" },
                    { 193, "BLR", "Country:alpha-3", "BLR" },
                    { 194, "BLR", "Country:country-code", "112" },
                    { 195, "BLR", "Country:iso_3166-2", "ISO 3166-2:BY" },
                    { 196, "BLR", "Country:region", "Europe" },
                    { 197, "BLR", "Country:sub-region", "Eastern Europe" },
                    { 198, "BLR", "Country:region-code", "150" },
                    { 199, "BLR", "Country:sub-region-code", "151" },
                    { 229, "BEN", "Country:sub-region-code", "202" },
                    { 200, "BEL", "Country:name", "Belgium" },
                    { 202, "BEL", "Country:alpha-3", "BEL" },
                    { 203, "BEL", "Country:country-code", "056" },
                    { 204, "BEL", "Country:iso_3166-2", "ISO 3166-2:BE" },
                    { 205, "BEL", "Country:region", "Europe" },
                    { 206, "BEL", "Country:sub-region", "Western Europe" },
                    { 207, "BEL", "Country:region-code", "150" },
                    { 208, "BEL", "Country:sub-region-code", "155" },
                    { 201, "BEL", "Country:alpha-2", "BE" },
                    { 1225, "LVA", "Country:region", "Europe" },
                    { 612, "DJI", "Country:iso_3166-2", "ISO 3166-2:DJ" },
                    { 614, "DJI", "Country:sub-region", "Sub-Saharan Africa" },
                    { 1018, "HUN", "Country:alpha-3", "HUN" },
                    { 1019, "HUN", "Country:country-code", "348" },
                    { 1020, "HUN", "Country:iso_3166-2", "ISO 3166-2:HU" },
                    { 1021, "HUN", "Country:region", "Europe" },
                    { 1022, "HUN", "Country:sub-region", "Eastern Europe" },
                    { 1023, "HUN", "Country:region-code", "150" },
                    { 1024, "HUN", "Country:sub-region-code", "151" },
                    { 1025, "ISL", "Country:name", "Iceland" },
                    { 1026, "ISL", "Country:alpha-2", "IS" },
                    { 1027, "ISL", "Country:alpha-3", "ISL" },
                    { 1028, "ISL", "Country:country-code", "352" },
                    { 1029, "ISL", "Country:iso_3166-2", "ISO 3166-2:IS" },
                    { 1030, "ISL", "Country:region", "Europe" },
                    { 1031, "ISL", "Country:sub-region", "Northern Europe" },
                    { 1032, "ISL", "Country:region-code", "150" },
                    { 1017, "HUN", "Country:alpha-2", "HU" },
                    { 1033, "ISL", "Country:sub-region-code", "154" },
                    { 1016, "HUN", "Country:name", "Hungary" },
                    { 1014, "HKG", "Country:region-code", "142" },
                    { 999, "HND", "Country:country-code", "340" },
                    { 1000, "HND", "Country:iso_3166-2", "ISO 3166-2:HN" },
                    { 1001, "HND", "Country:region", "Americas" },
                    { 1002, "HND", "Country:sub-region", "Latin America and the Caribbean" },
                    { 1003, "HND", "Country:intermediate-region", "Central America" },
                    { 1004, "HND", "Country:region-code", "019" },
                    { 1005, "HND", "Country:sub-region-code", "419" },
                    { 1006, "HND", "Country:intermediate-region-code", "013" },
                    { 1007, "HKG", "Country:name", "Hong Kong" },
                    { 1008, "HKG", "Country:alpha-2", "HK" },
                    { 1009, "HKG", "Country:alpha-3", "HKG" },
                    { 1010, "HKG", "Country:country-code", "344" },
                    { 1011, "HKG", "Country:iso_3166-2", "ISO 3166-2:HK" },
                    { 1012, "HKG", "Country:region", "Asia" },
                    { 1013, "HKG", "Country:sub-region", "Eastern Asia" },
                    { 1015, "HKG", "Country:sub-region-code", "030" },
                    { 998, "HND", "Country:alpha-3", "HND" },
                    { 1034, "IND", "Country:name", "India" },
                    { 1036, "IND", "Country:alpha-3", "IND" },
                    { 1056, "IRN", "Country:iso_3166-2", "ISO 3166-2:IR" },
                    { 1057, "IRN", "Country:region", "Asia" },
                    { 1058, "IRN", "Country:sub-region", "Southern Asia" },
                    { 1059, "IRN", "Country:region-code", "142" },
                    { 1060, "IRN", "Country:sub-region-code", "034" },
                    { 1061, "IRQ", "Country:name", "Iraq" },
                    { 1062, "IRQ", "Country:alpha-2", "IQ" },
                    { 1063, "IRQ", "Country:alpha-3", "IRQ" },
                    { 1064, "IRQ", "Country:country-code", "368" },
                    { 1065, "IRQ", "Country:iso_3166-2", "ISO 3166-2:IQ" },
                    { 1066, "IRQ", "Country:region", "Asia" },
                    { 1067, "IRQ", "Country:sub-region", "Western Asia" },
                    { 1068, "IRQ", "Country:region-code", "142" },
                    { 1069, "IRQ", "Country:sub-region-code", "145" },
                    { 1070, "IRL", "Country:name", "Ireland" },
                    { 1055, "IRN", "Country:country-code", "364" },
                    { 1035, "IND", "Country:alpha-2", "IN" },
                    { 1054, "IRN", "Country:alpha-3", "IRN" },
                    { 1052, "IRN", "Country:name", "Iran (Islamic Republic of)" },
                    { 1037, "IND", "Country:country-code", "356" },
                    { 1038, "IND", "Country:iso_3166-2", "ISO 3166-2:IN" },
                    { 1039, "IND", "Country:region", "Asia" },
                    { 1040, "IND", "Country:sub-region", "Southern Asia" },
                    { 1041, "IND", "Country:region-code", "142" },
                    { 1042, "IND", "Country:sub-region-code", "034" },
                    { 1043, "IDN", "Country:name", "Indonesia" },
                    { 1044, "IDN", "Country:alpha-2", "ID" },
                    { 1045, "IDN", "Country:alpha-3", "IDN" },
                    { 1046, "IDN", "Country:country-code", "360" },
                    { 1047, "IDN", "Country:iso_3166-2", "ISO 3166-2:ID" },
                    { 1048, "IDN", "Country:region", "Asia" },
                    { 1049, "IDN", "Country:sub-region", "South-eastern Asia" },
                    { 1050, "IDN", "Country:region-code", "142" },
                    { 1051, "IDN", "Country:sub-region-code", "035" },
                    { 1053, "IRN", "Country:alpha-2", "IR" },
                    { 997, "HND", "Country:alpha-2", "HN" },
                    { 996, "HND", "Country:name", "Honduras" },
                    { 995, "VAT", "Country:sub-region-code", "039" },
                    { 941, "GIN", "Country:intermediate-region", "Western Africa" },
                    { 942, "GIN", "Country:region-code", "002" },
                    { 943, "GIN", "Country:sub-region-code", "202" },
                    { 944, "GIN", "Country:intermediate-region-code", "011" },
                    { 945, "GNB", "Country:name", "Guinea-Bissau" },
                    { 946, "GNB", "Country:alpha-2", "GW" },
                    { 947, "GNB", "Country:alpha-3", "GNB" },
                    { 948, "GNB", "Country:country-code", "624" },
                    { 949, "GNB", "Country:iso_3166-2", "ISO 3166-2:GW" },
                    { 950, "GNB", "Country:region", "Africa" },
                    { 951, "GNB", "Country:sub-region", "Sub-Saharan Africa" },
                    { 952, "GNB", "Country:intermediate-region", "Western Africa" },
                    { 953, "GNB", "Country:region-code", "002" },
                    { 954, "GNB", "Country:sub-region-code", "202" },
                    { 955, "GNB", "Country:intermediate-region-code", "011" },
                    { 940, "GIN", "Country:sub-region", "Sub-Saharan Africa" },
                    { 956, "GUY", "Country:name", "Guyana" },
                    { 939, "GIN", "Country:region", "Africa" },
                    { 937, "GIN", "Country:country-code", "324" },
                    { 922, "GTM", "Country:intermediate-region-code", "013" },
                    { 923, "GGY", "Country:name", "Guernsey" },
                    { 924, "GGY", "Country:alpha-2", "GG" },
                    { 925, "GGY", "Country:alpha-3", "GGY" },
                    { 926, "GGY", "Country:country-code", "831" },
                    { 927, "GGY", "Country:iso_3166-2", "ISO 3166-2:GG" },
                    { 928, "GGY", "Country:region", "Europe" },
                    { 929, "GGY", "Country:sub-region", "Northern Europe" },
                    { 930, "GGY", "Country:intermediate-region", "Channel Islands" },
                    { 931, "GGY", "Country:region-code", "150" },
                    { 932, "GGY", "Country:sub-region-code", "154" },
                    { 933, "GGY", "Country:intermediate-region-code", "830" },
                    { 934, "GIN", "Country:name", "Guinea" },
                    { 935, "GIN", "Country:alpha-2", "GN" },
                    { 936, "GIN", "Country:alpha-3", "GIN" },
                    { 938, "GIN", "Country:iso_3166-2", "ISO 3166-2:GN" },
                    { 957, "GUY", "Country:alpha-2", "GY" },
                    { 958, "GUY", "Country:alpha-3", "GUY" },
                    { 959, "GUY", "Country:country-code", "328" },
                    { 980, "HMD", "Country:alpha-3", "HMD" },
                    { 981, "HMD", "Country:country-code", "334" },
                    { 982, "HMD", "Country:iso_3166-2", "ISO 3166-2:HM" },
                    { 983, "HMD", "Country:region", "Oceania" },
                    { 984, "HMD", "Country:sub-region", "Australia and New Zealand" },
                    { 985, "HMD", "Country:region-code", "009" },
                    { 986, "HMD", "Country:sub-region-code", "053" },
                    { 987, "VAT", "Country:name", "Holy See" },
                    { 988, "VAT", "Country:alpha-2", "VA" },
                    { 989, "VAT", "Country:alpha-3", "VAT" },
                    { 990, "VAT", "Country:country-code", "336" },
                    { 991, "VAT", "Country:iso_3166-2", "ISO 3166-2:VA" },
                    { 992, "VAT", "Country:region", "Europe" },
                    { 993, "VAT", "Country:sub-region", "Southern Europe" },
                    { 994, "VAT", "Country:region-code", "150" },
                    { 979, "HMD", "Country:alpha-2", "HM" },
                    { 978, "HMD", "Country:name", "Heard Island and McDonald Islands" },
                    { 977, "HTI", "Country:intermediate-region-code", "029" },
                    { 976, "HTI", "Country:sub-region-code", "419" },
                    { 960, "GUY", "Country:iso_3166-2", "ISO 3166-2:GY" },
                    { 961, "GUY", "Country:region", "Americas" },
                    { 962, "GUY", "Country:sub-region", "Latin America and the Caribbean" },
                    { 963, "GUY", "Country:intermediate-region", "South America" },
                    { 964, "GUY", "Country:region-code", "019" },
                    { 965, "GUY", "Country:sub-region-code", "419" },
                    { 966, "GUY", "Country:intermediate-region-code", "005" },
                    { 1071, "IRL", "Country:alpha-2", "IE" },
                    { 967, "HTI", "Country:name", "Haiti" },
                    { 969, "HTI", "Country:alpha-3", "HTI" },
                    { 970, "HTI", "Country:country-code", "332" },
                    { 971, "HTI", "Country:iso_3166-2", "ISO 3166-2:HT" },
                    { 972, "HTI", "Country:region", "Americas" },
                    { 973, "HTI", "Country:sub-region", "Latin America and the Caribbean" },
                    { 974, "HTI", "Country:intermediate-region", "Caribbean" },
                    { 975, "HTI", "Country:region-code", "019" },
                    { 968, "HTI", "Country:alpha-2", "HT" },
                    { 921, "GTM", "Country:sub-region-code", "419" },
                    { 1072, "IRL", "Country:alpha-3", "IRL" },
                    { 1074, "IRL", "Country:iso_3166-2", "ISO 3166-2:IE" },
                    { 1171, "KIR", "Country:region", "Oceania" },
                    { 1172, "KIR", "Country:sub-region", "Micronesia" },
                    { 1173, "KIR", "Country:region-code", "009" },
                    { 1174, "KIR", "Country:sub-region-code", "057" },
                    { 1175, "PRK", "Country:name", "Korea (Democratic People's Republic of)" },
                    { 1176, "PRK", "Country:alpha-2", "KP" },
                    { 1177, "PRK", "Country:alpha-3", "PRK" },
                    { 1178, "PRK", "Country:country-code", "408" },
                    { 1179, "PRK", "Country:iso_3166-2", "ISO 3166-2:KP" },
                    { 1180, "PRK", "Country:region", "Asia" },
                    { 1181, "PRK", "Country:sub-region", "Eastern Asia" },
                    { 1182, "PRK", "Country:region-code", "142" },
                    { 1183, "PRK", "Country:sub-region-code", "030" },
                    { 1184, "KOR", "Country:name", "Korea" },
                    { 1185, "KOR", "Country:alpha-2", "KR" },
                    { 1170, "KIR", "Country:iso_3166-2", "ISO 3166-2:KI" },
                    { 1186, "KOR", "Country:alpha-3", "KOR" },
                    { 1169, "KIR", "Country:country-code", "296" },
                    { 1167, "KIR", "Country:alpha-2", "KI" },
                    { 1152, "KAZ", "Country:sub-region", "Central Asia" },
                    { 1153, "KAZ", "Country:region-code", "142" },
                    { 1154, "KAZ", "Country:sub-region-code", "143" },
                    { 1155, "KEN", "Country:name", "Kenya" },
                    { 1156, "KEN", "Country:alpha-2", "KE" },
                    { 1157, "KEN", "Country:alpha-3", "KEN" },
                    { 1158, "KEN", "Country:country-code", "404" },
                    { 1159, "KEN", "Country:iso_3166-2", "ISO 3166-2:KE" },
                    { 1160, "KEN", "Country:region", "Africa" },
                    { 1161, "KEN", "Country:sub-region", "Sub-Saharan Africa" },
                    { 1162, "KEN", "Country:intermediate-region", "Eastern Africa" },
                    { 1163, "KEN", "Country:region-code", "002" },
                    { 1164, "KEN", "Country:sub-region-code", "202" },
                    { 1165, "KEN", "Country:intermediate-region-code", "014" },
                    { 1166, "KIR", "Country:name", "Kiribati" },
                    { 1168, "KIR", "Country:alpha-3", "KIR" },
                    { 1151, "KAZ", "Country:region", "Asia" },
                    { 1187, "KOR", "Country:country-code", "410" },
                    { 1189, "KOR", "Country:region", "Asia" },
                    { 1209, "KGZ", "Country:region-code", "142" },
                    { 1210, "KGZ", "Country:sub-region-code", "143" },
                    { 1211, "LAO", "Country:name", "Lao People's Democratic Republic" },
                    { 1212, "LAO", "Country:alpha-2", "LA" },
                    { 1213, "LAO", "Country:alpha-3", "LAO" },
                    { 1214, "LAO", "Country:country-code", "418" },
                    { 1215, "LAO", "Country:iso_3166-2", "ISO 3166-2:LA" },
                    { 1216, "LAO", "Country:region", "Asia" },
                    { 1217, "LAO", "Country:sub-region", "South-eastern Asia" },
                    { 1218, "LAO", "Country:region-code", "142" },
                    { 1219, "LAO", "Country:sub-region-code", "035" },
                    { 1220, "LVA", "Country:name", "Latvia" },
                    { 1221, "LVA", "Country:alpha-2", "LV" },
                    { 1222, "LVA", "Country:alpha-3", "LVA" },
                    { 1223, "LVA", "Country:country-code", "428" },
                    { 1208, "KGZ", "Country:sub-region", "Central Asia" },
                    { 1188, "KOR", "Country:iso_3166-2", "ISO 3166-2:KR" },
                    { 1207, "KGZ", "Country:region", "Asia" },
                    { 1205, "KGZ", "Country:country-code", "417" },
                    { 1190, "KOR", "Country:sub-region", "Eastern Asia" },
                    { 1191, "KOR", "Country:region-code", "142" },
                    { 1192, "KOR", "Country:sub-region-code", "030" },
                    { 1193, "KWT", "Country:name", "Kuwait" },
                    { 1194, "KWT", "Country:alpha-2", "KW" },
                    { 1195, "KWT", "Country:alpha-3", "KWT" },
                    { 1196, "KWT", "Country:country-code", "414" },
                    { 1197, "KWT", "Country:iso_3166-2", "ISO 3166-2:KW" },
                    { 1198, "KWT", "Country:region", "Asia" },
                    { 1199, "KWT", "Country:sub-region", "Western Asia" },
                    { 1200, "KWT", "Country:region-code", "142" },
                    { 1201, "KWT", "Country:sub-region-code", "145" },
                    { 1202, "KGZ", "Country:name", "Kyrgyzstan" },
                    { 1203, "KGZ", "Country:alpha-2", "KG" },
                    { 1204, "KGZ", "Country:alpha-3", "KGZ" },
                    { 1206, "KGZ", "Country:iso_3166-2", "ISO 3166-2:KG" },
                    { 1150, "KAZ", "Country:iso_3166-2", "ISO 3166-2:KZ" },
                    { 1149, "KAZ", "Country:country-code", "398" },
                    { 1148, "KAZ", "Country:alpha-3", "KAZ" },
                    { 1094, "ISR", "Country:sub-region", "Western Asia" },
                    { 1095, "ISR", "Country:region-code", "142" },
                    { 1096, "ISR", "Country:sub-region-code", "145" },
                    { 1097, "ITA", "Country:name", "Italy" },
                    { 1098, "ITA", "Country:alpha-2", "IT" },
                    { 1099, "ITA", "Country:alpha-3", "ITA" },
                    { 1100, "ITA", "Country:country-code", "380" },
                    { 1101, "ITA", "Country:iso_3166-2", "ISO 3166-2:IT" },
                    { 1102, "ITA", "Country:region", "Europe" },
                    { 1103, "ITA", "Country:sub-region", "Southern Europe" },
                    { 1104, "ITA", "Country:region-code", "150" },
                    { 1105, "ITA", "Country:sub-region-code", "039" },
                    { 1106, "JAM", "Country:name", "Jamaica" },
                    { 1107, "JAM", "Country:alpha-2", "JM" },
                    { 1108, "JAM", "Country:alpha-3", "JAM" },
                    { 1093, "ISR", "Country:region", "Asia" },
                    { 1109, "JAM", "Country:country-code", "388" },
                    { 1092, "ISR", "Country:iso_3166-2", "ISO 3166-2:IL" },
                    { 1090, "ISR", "Country:alpha-3", "ISR" },
                    { 1075, "IRL", "Country:region", "Europe" },
                    { 1076, "IRL", "Country:sub-region", "Northern Europe" },
                    { 1077, "IRL", "Country:region-code", "150" },
                    { 1078, "IRL", "Country:sub-region-code", "154" },
                    { 1079, "IMN", "Country:name", "Isle of Man" },
                    { 1080, "IMN", "Country:alpha-2", "IM" },
                    { 1081, "IMN", "Country:alpha-3", "IMN" },
                    { 1082, "IMN", "Country:country-code", "833" }
                });

            migrationBuilder.InsertData(
                table: "ReferenceDataItems",
                columns: new[] { "ID", "Key", "Path", "Value" },
                values: new object[,]
                {
                    { 1083, "IMN", "Country:iso_3166-2", "ISO 3166-2:IM" },
                    { 1084, "IMN", "Country:region", "Europe" },
                    { 1085, "IMN", "Country:sub-region", "Northern Europe" },
                    { 1086, "IMN", "Country:region-code", "150" },
                    { 1087, "IMN", "Country:sub-region-code", "154" },
                    { 1088, "ISR", "Country:name", "Israel" },
                    { 1089, "ISR", "Country:alpha-2", "IL" },
                    { 1091, "ISR", "Country:country-code", "376" },
                    { 1110, "JAM", "Country:iso_3166-2", "ISO 3166-2:JM" },
                    { 1111, "JAM", "Country:region", "Americas" },
                    { 1112, "JAM", "Country:sub-region", "Latin America and the Caribbean" },
                    { 1133, "JEY", "Country:intermediate-region", "Channel Islands" },
                    { 1134, "JEY", "Country:region-code", "150" },
                    { 1135, "JEY", "Country:sub-region-code", "154" },
                    { 1136, "JEY", "Country:intermediate-region-code", "830" },
                    { 1137, "JOR", "Country:name", "Jordan" },
                    { 1138, "JOR", "Country:alpha-2", "JO" },
                    { 1139, "JOR", "Country:alpha-3", "JOR" },
                    { 1140, "JOR", "Country:country-code", "400" },
                    { 1141, "JOR", "Country:iso_3166-2", "ISO 3166-2:JO" },
                    { 1142, "JOR", "Country:region", "Asia" },
                    { 1143, "JOR", "Country:sub-region", "Western Asia" },
                    { 1144, "JOR", "Country:region-code", "142" },
                    { 1145, "JOR", "Country:sub-region-code", "145" },
                    { 1146, "KAZ", "Country:name", "Kazakhstan" },
                    { 1147, "KAZ", "Country:alpha-2", "KZ" },
                    { 1132, "JEY", "Country:sub-region", "Northern Europe" },
                    { 1131, "JEY", "Country:region", "Europe" },
                    { 1130, "JEY", "Country:iso_3166-2", "ISO 3166-2:JE" },
                    { 1129, "JEY", "Country:country-code", "832" },
                    { 1113, "JAM", "Country:intermediate-region", "Caribbean" },
                    { 1114, "JAM", "Country:region-code", "019" },
                    { 1115, "JAM", "Country:sub-region-code", "419" },
                    { 1116, "JAM", "Country:intermediate-region-code", "029" },
                    { 1117, "JPN", "Country:name", "Japan" },
                    { 1118, "JPN", "Country:alpha-2", "JP" },
                    { 1119, "JPN", "Country:alpha-3", "JPN" },
                    { 1073, "IRL", "Country:country-code", "372" },
                    { 1120, "JPN", "Country:country-code", "392" },
                    { 1122, "JPN", "Country:region", "Asia" },
                    { 1123, "JPN", "Country:sub-region", "Eastern Asia" },
                    { 1124, "JPN", "Country:region-code", "142" },
                    { 1125, "JPN", "Country:sub-region-code", "030" },
                    { 1126, "JEY", "Country:name", "Jersey" },
                    { 1127, "JEY", "Country:alpha-2", "JE" },
                    { 1128, "JEY", "Country:alpha-3", "JEY" },
                    { 1121, "JPN", "Country:iso_3166-2", "ISO 3166-2:JP" },
                    { 920, "GTM", "Country:region-code", "019" },
                    { 919, "GTM", "Country:intermediate-region", "Central America" },
                    { 918, "GTM", "Country:sub-region", "Latin America and the Caribbean" },
                    { 711, "SWZ", "Country:region-code", "002" },
                    { 712, "SWZ", "Country:sub-region-code", "202" },
                    { 713, "SWZ", "Country:intermediate-region-code", "018" },
                    { 714, "ETH", "Country:name", "Ethiopia" },
                    { 715, "ETH", "Country:alpha-2", "ET" },
                    { 716, "ETH", "Country:alpha-3", "ETH" },
                    { 717, "ETH", "Country:country-code", "231" },
                    { 718, "ETH", "Country:iso_3166-2", "ISO 3166-2:ET" },
                    { 719, "ETH", "Country:region", "Africa" },
                    { 720, "ETH", "Country:sub-region", "Sub-Saharan Africa" },
                    { 721, "ETH", "Country:intermediate-region", "Eastern Africa" },
                    { 722, "ETH", "Country:region-code", "002" },
                    { 723, "ETH", "Country:sub-region-code", "202" },
                    { 724, "ETH", "Country:intermediate-region-code", "014" },
                    { 725, "FLK", "Country:name", "Falkland Islands (Malvinas)" },
                    { 710, "SWZ", "Country:intermediate-region", "Southern Africa" },
                    { 726, "FLK", "Country:alpha-2", "FK" },
                    { 709, "SWZ", "Country:sub-region", "Sub-Saharan Africa" },
                    { 707, "SWZ", "Country:iso_3166-2", "ISO 3166-2:SZ" },
                    { 692, "ERI", "Country:sub-region-code", "202" },
                    { 693, "ERI", "Country:intermediate-region-code", "014" },
                    { 694, "EST", "Country:name", "Estonia" },
                    { 695, "EST", "Country:alpha-2", "EE" },
                    { 696, "EST", "Country:alpha-3", "EST" },
                    { 697, "EST", "Country:country-code", "233" },
                    { 698, "EST", "Country:iso_3166-2", "ISO 3166-2:EE" },
                    { 699, "EST", "Country:region", "Europe" },
                    { 700, "EST", "Country:sub-region", "Northern Europe" },
                    { 701, "EST", "Country:region-code", "150" },
                    { 702, "EST", "Country:sub-region-code", "154" },
                    { 703, "SWZ", "Country:name", "Eswatini" },
                    { 704, "SWZ", "Country:alpha-2", "SZ" },
                    { 705, "SWZ", "Country:alpha-3", "SWZ" },
                    { 706, "SWZ", "Country:country-code", "748" },
                    { 708, "SWZ", "Country:region", "Africa" },
                    { 691, "ERI", "Country:region-code", "002" },
                    { 727, "FLK", "Country:alpha-3", "FLK" },
                    { 729, "FLK", "Country:iso_3166-2", "ISO 3166-2:FK" },
                    { 749, "FJI", "Country:iso_3166-2", "ISO 3166-2:FJ" },
                    { 750, "FJI", "Country:region", "Oceania" },
                    { 751, "FJI", "Country:sub-region", "Melanesia" },
                    { 752, "FJI", "Country:region-code", "009" },
                    { 753, "FJI", "Country:sub-region-code", "054" },
                    { 754, "FIN", "Country:name", "Finland" },
                    { 755, "FIN", "Country:alpha-2", "FI" },
                    { 756, "FIN", "Country:alpha-3", "FIN" },
                    { 757, "FIN", "Country:country-code", "246" },
                    { 758, "FIN", "Country:iso_3166-2", "ISO 3166-2:FI" },
                    { 759, "FIN", "Country:region", "Europe" },
                    { 760, "FIN", "Country:sub-region", "Northern Europe" },
                    { 761, "FIN", "Country:region-code", "150" },
                    { 762, "FIN", "Country:sub-region-code", "154" },
                    { 763, "FRA", "Country:name", "France" },
                    { 748, "FJI", "Country:country-code", "242" },
                    { 728, "FLK", "Country:country-code", "238" },
                    { 747, "FJI", "Country:alpha-3", "FJI" },
                    { 745, "FJI", "Country:name", "Fiji" },
                    { 730, "FLK", "Country:region", "Americas" },
                    { 731, "FLK", "Country:sub-region", "Latin America and the Caribbean" },
                    { 732, "FLK", "Country:intermediate-region", "South America" },
                    { 733, "FLK", "Country:region-code", "019" },
                    { 734, "FLK", "Country:sub-region-code", "419" },
                    { 735, "FLK", "Country:intermediate-region-code", "005" },
                    { 736, "FRO", "Country:name", "Faroe Islands" },
                    { 737, "FRO", "Country:alpha-2", "FO" },
                    { 738, "FRO", "Country:alpha-3", "FRO" },
                    { 739, "FRO", "Country:country-code", "234" },
                    { 740, "FRO", "Country:iso_3166-2", "ISO 3166-2:FO" },
                    { 741, "FRO", "Country:region", "Europe" },
                    { 742, "FRO", "Country:sub-region", "Northern Europe" },
                    { 743, "FRO", "Country:region-code", "150" },
                    { 744, "FRO", "Country:sub-region-code", "154" },
                    { 746, "FJI", "Country:alpha-2", "FJ" },
                    { 690, "ERI", "Country:intermediate-region", "Eastern Africa" },
                    { 689, "ERI", "Country:sub-region", "Sub-Saharan Africa" },
                    { 688, "ERI", "Country:region", "Africa" },
                    { 634, "DOM", "Country:iso_3166-2", "ISO 3166-2:DO" },
                    { 635, "DOM", "Country:region", "Americas" },
                    { 636, "DOM", "Country:sub-region", "Latin America and the Caribbean" },
                    { 637, "DOM", "Country:intermediate-region", "Caribbean" },
                    { 638, "DOM", "Country:region-code", "019" },
                    { 639, "DOM", "Country:sub-region-code", "419" },
                    { 640, "DOM", "Country:intermediate-region-code", "029" },
                    { 641, "ECU", "Country:name", "Ecuador" },
                    { 642, "ECU", "Country:alpha-2", "EC" },
                    { 643, "ECU", "Country:alpha-3", "ECU" },
                    { 644, "ECU", "Country:country-code", "218" },
                    { 645, "ECU", "Country:iso_3166-2", "ISO 3166-2:EC" },
                    { 646, "ECU", "Country:region", "Americas" },
                    { 647, "ECU", "Country:sub-region", "Latin America and the Caribbean" },
                    { 648, "ECU", "Country:intermediate-region", "South America" },
                    { 633, "DOM", "Country:country-code", "214" },
                    { 649, "ECU", "Country:region-code", "019" },
                    { 632, "DOM", "Country:alpha-3", "DOM" },
                    { 630, "DOM", "Country:name", "Dominican Republic" },
                    { 615, "DJI", "Country:intermediate-region", "Eastern Africa" },
                    { 616, "DJI", "Country:region-code", "002" },
                    { 617, "DJI", "Country:sub-region-code", "202" },
                    { 618, "DJI", "Country:intermediate-region-code", "014" },
                    { 619, "DMA", "Country:name", "Dominica" },
                    { 620, "DMA", "Country:alpha-2", "DM" },
                    { 621, "DMA", "Country:alpha-3", "DMA" },
                    { 622, "DMA", "Country:country-code", "212" },
                    { 623, "DMA", "Country:iso_3166-2", "ISO 3166-2:DM" },
                    { 624, "DMA", "Country:region", "Americas" },
                    { 625, "DMA", "Country:sub-region", "Latin America and the Caribbean" },
                    { 626, "DMA", "Country:intermediate-region", "Caribbean" },
                    { 627, "DMA", "Country:region-code", "019" },
                    { 628, "DMA", "Country:sub-region-code", "419" },
                    { 629, "DMA", "Country:intermediate-region-code", "029" },
                    { 631, "DOM", "Country:alpha-2", "DO" },
                    { 650, "ECU", "Country:sub-region-code", "419" },
                    { 651, "ECU", "Country:intermediate-region-code", "005" },
                    { 652, "EGY", "Country:name", "Egypt" },
                    { 673, "GNQ", "Country:alpha-2", "GQ" },
                    { 674, "GNQ", "Country:alpha-3", "GNQ" },
                    { 675, "GNQ", "Country:country-code", "226" },
                    { 676, "GNQ", "Country:iso_3166-2", "ISO 3166-2:GQ" },
                    { 677, "GNQ", "Country:region", "Africa" },
                    { 678, "GNQ", "Country:sub-region", "Sub-Saharan Africa" },
                    { 679, "GNQ", "Country:intermediate-region", "Middle Africa" },
                    { 680, "GNQ", "Country:region-code", "002" },
                    { 681, "GNQ", "Country:sub-region-code", "202" },
                    { 682, "GNQ", "Country:intermediate-region-code", "017" },
                    { 683, "ERI", "Country:name", "Eritrea" },
                    { 684, "ERI", "Country:alpha-2", "ER" },
                    { 685, "ERI", "Country:alpha-3", "ERI" },
                    { 686, "ERI", "Country:country-code", "232" },
                    { 687, "ERI", "Country:iso_3166-2", "ISO 3166-2:ER" },
                    { 672, "GNQ", "Country:name", "Equatorial Guinea" },
                    { 671, "SLV", "Country:intermediate-region-code", "013" },
                    { 670, "SLV", "Country:sub-region-code", "419" },
                    { 669, "SLV", "Country:region-code", "019" },
                    { 653, "EGY", "Country:alpha-2", "EG" },
                    { 654, "EGY", "Country:alpha-3", "EGY" },
                    { 655, "EGY", "Country:country-code", "818" },
                    { 656, "EGY", "Country:iso_3166-2", "ISO 3166-2:EG" },
                    { 657, "EGY", "Country:region", "Africa" },
                    { 658, "EGY", "Country:sub-region", "Northern Africa" },
                    { 659, "EGY", "Country:region-code", "002" },
                    { 764, "FRA", "Country:alpha-2", "FR" },
                    { 660, "EGY", "Country:sub-region-code", "015" },
                    { 662, "SLV", "Country:alpha-2", "SV" },
                    { 663, "SLV", "Country:alpha-3", "SLV" },
                    { 664, "SLV", "Country:country-code", "222" },
                    { 665, "SLV", "Country:iso_3166-2", "ISO 3166-2:SV" },
                    { 666, "SLV", "Country:region", "Americas" },
                    { 667, "SLV", "Country:sub-region", "Latin America and the Caribbean" },
                    { 668, "SLV", "Country:intermediate-region", "Central America" },
                    { 661, "SLV", "Country:name", "El Salvador" },
                    { 765, "FRA", "Country:alpha-3", "FRA" },
                    { 766, "FRA", "Country:country-code", "250" },
                    { 767, "FRA", "Country:iso_3166-2", "ISO 3166-2:FR" },
                    { 864, "GRC", "Country:alpha-2", "GR" },
                    { 865, "GRC", "Country:alpha-3", "GRC" },
                    { 866, "GRC", "Country:country-code", "300" },
                    { 867, "GRC", "Country:iso_3166-2", "ISO 3166-2:GR" },
                    { 868, "GRC", "Country:region", "Europe" },
                    { 869, "GRC", "Country:sub-region", "Southern Europe" },
                    { 870, "GRC", "Country:region-code", "150" },
                    { 871, "GRC", "Country:sub-region-code", "039" },
                    { 872, "GRL", "Country:name", "Greenland" },
                    { 873, "GRL", "Country:alpha-2", "GL" },
                    { 874, "GRL", "Country:alpha-3", "GRL" },
                    { 875, "GRL", "Country:country-code", "304" },
                    { 876, "GRL", "Country:iso_3166-2", "ISO 3166-2:GL" },
                    { 877, "GRL", "Country:region", "Americas" },
                    { 878, "GRL", "Country:sub-region", "Northern America" },
                    { 863, "GRC", "Country:name", "Greece" },
                    { 879, "GRL", "Country:region-code", "019" },
                    { 862, "GIB", "Country:sub-region-code", "039" },
                    { 860, "GIB", "Country:sub-region", "Southern Europe" },
                    { 845, "GHA", "Country:alpha-3", "GHA" },
                    { 846, "GHA", "Country:country-code", "288" },
                    { 847, "GHA", "Country:iso_3166-2", "ISO 3166-2:GH" },
                    { 848, "GHA", "Country:region", "Africa" },
                    { 849, "GHA", "Country:sub-region", "Sub-Saharan Africa" },
                    { 850, "GHA", "Country:intermediate-region", "Western Africa" },
                    { 851, "GHA", "Country:region-code", "002" },
                    { 852, "GHA", "Country:sub-region-code", "202" },
                    { 853, "GHA", "Country:intermediate-region-code", "011" },
                    { 854, "GIB", "Country:name", "Gibraltar" },
                    { 855, "GIB", "Country:alpha-2", "GI" },
                    { 856, "GIB", "Country:alpha-3", "GIB" },
                    { 857, "GIB", "Country:country-code", "292" },
                    { 858, "GIB", "Country:iso_3166-2", "ISO 3166-2:GI" },
                    { 859, "GIB", "Country:region", "Europe" },
                    { 861, "GIB", "Country:region-code", "150" },
                    { 880, "GRL", "Country:sub-region-code", "021" },
                    { 881, "GRD", "Country:name", "Grenada" },
                    { 882, "GRD", "Country:alpha-2", "GD" },
                    { 903, "GUM", "Country:name", "Guam" },
                    { 904, "GUM", "Country:alpha-2", "GU" },
                    { 905, "GUM", "Country:alpha-3", "GUM" },
                    { 906, "GUM", "Country:country-code", "316" },
                    { 907, "GUM", "Country:iso_3166-2", "ISO 3166-2:GU" },
                    { 908, "GUM", "Country:region", "Oceania" },
                    { 909, "GUM", "Country:sub-region", "Micronesia" },
                    { 910, "GUM", "Country:region-code", "009" },
                    { 911, "GUM", "Country:sub-region-code", "057" },
                    { 912, "GTM", "Country:name", "Guatemala" },
                    { 913, "GTM", "Country:alpha-2", "GT" },
                    { 914, "GTM", "Country:alpha-3", "GTM" },
                    { 915, "GTM", "Country:country-code", "320" },
                    { 916, "GTM", "Country:iso_3166-2", "ISO 3166-2:GT" },
                    { 917, "GTM", "Country:region", "Americas" },
                    { 902, "GLP", "Country:intermediate-region-code", "029" },
                    { 901, "GLP", "Country:sub-region-code", "419" },
                    { 900, "GLP", "Country:region-code", "019" },
                    { 899, "GLP", "Country:intermediate-region", "Caribbean" },
                    { 883, "GRD", "Country:alpha-3", "GRD" },
                    { 884, "GRD", "Country:country-code", "308" },
                    { 885, "GRD", "Country:iso_3166-2", "ISO 3166-2:GD" },
                    { 886, "GRD", "Country:region", "Americas" },
                    { 887, "GRD", "Country:sub-region", "Latin America and the Caribbean" },
                    { 888, "GRD", "Country:intermediate-region", "Caribbean" },
                    { 889, "GRD", "Country:region-code", "019" },
                    { 844, "GHA", "Country:alpha-2", "GH" },
                    { 890, "GRD", "Country:sub-region-code", "419" },
                    { 892, "GLP", "Country:name", "Guadeloupe" },
                    { 893, "GLP", "Country:alpha-2", "GP" },
                    { 894, "GLP", "Country:alpha-3", "GLP" },
                    { 895, "GLP", "Country:country-code", "312" },
                    { 896, "GLP", "Country:iso_3166-2", "ISO 3166-2:GP" },
                    { 897, "GLP", "Country:region", "Americas" },
                    { 898, "GLP", "Country:sub-region", "Latin America and the Caribbean" },
                    { 891, "GRD", "Country:intermediate-region-code", "029" },
                    { 613, "DJI", "Country:region", "Africa" },
                    { 843, "GHA", "Country:name", "Ghana" },
                    { 841, "DEU", "Country:region-code", "150" },
                    { 787, "PYF", "Country:iso_3166-2", "ISO 3166-2:PF" },
                    { 788, "PYF", "Country:region", "Oceania" },
                    { 789, "PYF", "Country:sub-region", "Polynesia" },
                    { 790, "PYF", "Country:region-code", "009" },
                    { 791, "PYF", "Country:sub-region-code", "061" },
                    { 792, "ATF", "Country:name", "French Southern Territories" },
                    { 793, "ATF", "Country:alpha-2", "TF" },
                    { 794, "ATF", "Country:alpha-3", "ATF" },
                    { 795, "ATF", "Country:country-code", "260" },
                    { 796, "ATF", "Country:iso_3166-2", "ISO 3166-2:TF" },
                    { 797, "ATF", "Country:region", "Africa" },
                    { 798, "ATF", "Country:sub-region", "Sub-Saharan Africa" },
                    { 799, "ATF", "Country:intermediate-region", "Eastern Africa" },
                    { 800, "ATF", "Country:region-code", "002" },
                    { 801, "ATF", "Country:sub-region-code", "202" },
                    { 786, "PYF", "Country:country-code", "258" },
                    { 802, "ATF", "Country:intermediate-region-code", "014" },
                    { 785, "PYF", "Country:alpha-3", "PYF" },
                    { 783, "PYF", "Country:name", "French Polynesia" },
                    { 768, "FRA", "Country:region", "Europe" },
                    { 769, "FRA", "Country:sub-region", "Western Europe" },
                    { 770, "FRA", "Country:region-code", "150" },
                    { 771, "FRA", "Country:sub-region-code", "155" },
                    { 772, "GUF", "Country:name", "French Guiana" },
                    { 773, "GUF", "Country:alpha-2", "GF" },
                    { 774, "GUF", "Country:alpha-3", "GUF" },
                    { 775, "GUF", "Country:country-code", "254" },
                    { 776, "GUF", "Country:iso_3166-2", "ISO 3166-2:GF" },
                    { 777, "GUF", "Country:region", "Americas" },
                    { 778, "GUF", "Country:sub-region", "Latin America and the Caribbean" },
                    { 779, "GUF", "Country:intermediate-region", "South America" },
                    { 780, "GUF", "Country:region-code", "019" },
                    { 781, "GUF", "Country:sub-region-code", "419" },
                    { 782, "GUF", "Country:intermediate-region-code", "005" },
                    { 784, "PYF", "Country:alpha-2", "PF" },
                    { 803, "GAB", "Country:name", "Gabon" },
                    { 804, "GAB", "Country:alpha-2", "GA" },
                    { 805, "GAB", "Country:alpha-3", "GAB" },
                    { 826, "GEO", "Country:alpha-2", "GE" },
                    { 827, "GEO", "Country:alpha-3", "GEO" },
                    { 828, "GEO", "Country:country-code", "268" },
                    { 829, "GEO", "Country:iso_3166-2", "ISO 3166-2:GE" },
                    { 830, "GEO", "Country:region", "Asia" },
                    { 831, "GEO", "Country:sub-region", "Western Asia" },
                    { 832, "GEO", "Country:region-code", "142" },
                    { 833, "GEO", "Country:sub-region-code", "145" },
                    { 834, "DEU", "Country:name", "Germany" },
                    { 835, "DEU", "Country:alpha-2", "DE" },
                    { 836, "DEU", "Country:alpha-3", "DEU" },
                    { 837, "DEU", "Country:country-code", "276" },
                    { 838, "DEU", "Country:iso_3166-2", "ISO 3166-2:DE" },
                    { 839, "DEU", "Country:region", "Europe" },
                    { 840, "DEU", "Country:sub-region", "Western Europe" },
                    { 825, "GEO", "Country:name", "Georgia" },
                    { 824, "GMB", "Country:intermediate-region-code", "011" },
                    { 823, "GMB", "Country:sub-region-code", "202" },
                    { 822, "GMB", "Country:region-code", "002" },
                    { 806, "GAB", "Country:country-code", "266" },
                    { 807, "GAB", "Country:iso_3166-2", "ISO 3166-2:GA" },
                    { 808, "GAB", "Country:region", "Africa" },
                    { 809, "GAB", "Country:sub-region", "Sub-Saharan Africa" },
                    { 810, "GAB", "Country:intermediate-region", "Middle Africa" },
                    { 811, "GAB", "Country:region-code", "002" },
                    { 812, "GAB", "Country:sub-region-code", "202" },
                    { 842, "DEU", "Country:sub-region-code", "155" },
                    { 813, "GAB", "Country:intermediate-region-code", "017" },
                    { 815, "GMB", "Country:alpha-2", "GM" },
                    { 816, "GMB", "Country:alpha-3", "GMB" },
                    { 817, "GMB", "Country:country-code", "270" },
                    { 818, "GMB", "Country:iso_3166-2", "ISO 3166-2:GM" },
                    { 819, "GMB", "Country:region", "Africa" },
                    { 820, "GMB", "Country:sub-region", "Sub-Saharan Africa" },
                    { 821, "GMB", "Country:intermediate-region", "Western Africa" },
                    { 814, "GMB", "Country:name", "Gambia" },
                    { 2451, "ZWE", "Country:intermediate-region-code", "014" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 152);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 153);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 154);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 155);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 156);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 157);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 158);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 159);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 160);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 161);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 162);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 163);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 164);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 165);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 166);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 167);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 168);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 169);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 170);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 171);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 172);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 173);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 174);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 175);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 176);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 177);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 178);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 179);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 180);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 181);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 182);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 183);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 184);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 185);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 186);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 187);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 188);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 189);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 190);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 191);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 192);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 193);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 194);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 195);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 196);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 197);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 198);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 199);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 200);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 201);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 202);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 203);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 204);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 205);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 206);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 207);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 208);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 209);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 210);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 211);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 212);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 213);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 214);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 215);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 216);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 217);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 218);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 219);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 220);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 221);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 222);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 223);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 224);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 225);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 226);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 227);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 228);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 229);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 230);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 231);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 232);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 233);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 234);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 235);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 236);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 237);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 238);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 239);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 240);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 241);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 242);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 243);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 244);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 245);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 246);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 247);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 248);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 249);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 250);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 251);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 252);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 253);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 254);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 255);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 256);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 257);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 258);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 259);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 260);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 261);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 262);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 263);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 264);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 265);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 266);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 267);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 268);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 269);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 270);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 271);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 272);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 273);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 274);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 275);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 276);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 277);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 278);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 279);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 280);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 281);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 282);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 283);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 284);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 285);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 286);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 287);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 288);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 289);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 290);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 291);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 292);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 293);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 294);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 295);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 296);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 297);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 298);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 299);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 300);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 301);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 302);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 303);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 304);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 305);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 306);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 307);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 308);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 309);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 310);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 311);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 312);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 313);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 314);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 315);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 316);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 317);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 318);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 319);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 320);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 321);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 322);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 323);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 324);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 325);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 326);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 327);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 328);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 329);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 330);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 331);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 332);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 333);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 334);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 335);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 336);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 337);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 338);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 339);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 340);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 341);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 342);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 343);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 344);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 345);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 346);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 347);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 348);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 349);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 350);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 351);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 352);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 353);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 354);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 355);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 356);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 357);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 358);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 359);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 360);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 361);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 362);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 363);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 364);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 365);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 366);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 367);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 368);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 369);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 370);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 371);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 372);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 373);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 374);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 375);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 376);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 377);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 378);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 379);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 380);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 381);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 382);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 383);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 384);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 385);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 386);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 387);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 388);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 389);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 390);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 391);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 392);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 393);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 394);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 395);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 396);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 397);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 398);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 399);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 400);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 401);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 402);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 403);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 404);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 405);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 406);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 407);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 408);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 409);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 410);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 411);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 412);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 413);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 414);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 415);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 416);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 417);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 418);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 419);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 420);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 421);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 422);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 423);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 424);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 425);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 426);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 427);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 428);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 429);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 430);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 431);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 432);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 433);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 434);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 435);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 436);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 437);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 438);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 439);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 440);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 441);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 442);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 443);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 444);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 445);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 446);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 447);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 448);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 449);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 450);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 451);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 452);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 453);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 454);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 455);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 456);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 457);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 458);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 459);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 460);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 461);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 462);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 463);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 464);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 465);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 466);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 467);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 468);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 469);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 470);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 471);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 472);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 473);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 474);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 475);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 476);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 477);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 478);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 479);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 480);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 481);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 482);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 483);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 484);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 485);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 486);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 487);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 488);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 489);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 490);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 491);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 492);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 493);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 494);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 495);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 496);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 497);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 498);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 499);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 500);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 501);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 502);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 503);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 504);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 505);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 506);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 507);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 508);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 509);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 510);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 511);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 512);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 513);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 514);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 515);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 516);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 517);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 518);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 519);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 520);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 521);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 522);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 523);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 524);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 525);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 526);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 527);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 528);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 529);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 530);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 531);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 532);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 533);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 534);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 535);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 536);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 537);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 538);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 539);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 540);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 541);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 542);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 543);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 544);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 545);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 546);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 547);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 548);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 549);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 550);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 551);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 552);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 553);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 554);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 555);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 556);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 557);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 558);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 559);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 560);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 561);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 562);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 563);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 564);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 565);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 566);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 567);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 568);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 569);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 570);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 571);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 572);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 573);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 574);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 575);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 576);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 577);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 578);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 579);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 580);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 581);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 582);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 583);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 584);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 585);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 586);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 587);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 588);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 589);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 590);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 591);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 592);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 593);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 594);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 595);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 596);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 597);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 598);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 599);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 600);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 601);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 602);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 603);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 604);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 605);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 606);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 607);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 608);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 609);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 610);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 611);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 612);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 613);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 614);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 615);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 616);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 617);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 618);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 619);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 620);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 621);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 622);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 623);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 624);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 625);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 626);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 627);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 628);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 629);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 630);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 631);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 632);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 633);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 634);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 635);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 636);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 637);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 638);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 639);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 640);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 641);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 642);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 643);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 644);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 645);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 646);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 647);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 648);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 649);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 650);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 651);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 652);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 653);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 654);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 655);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 656);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 657);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 658);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 659);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 660);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 661);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 662);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 663);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 664);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 665);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 666);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 667);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 668);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 669);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 670);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 671);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 672);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 673);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 674);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 675);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 676);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 677);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 678);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 679);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 680);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 681);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 682);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 683);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 684);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 685);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 686);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 687);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 688);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 689);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 690);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 691);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 692);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 693);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 694);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 695);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 696);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 697);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 698);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 699);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 700);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 701);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 702);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 703);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 704);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 705);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 706);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 707);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 708);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 709);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 710);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 711);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 712);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 713);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 714);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 715);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 716);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 717);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 718);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 719);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 720);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 721);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 722);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 723);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 724);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 725);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 726);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 727);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 728);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 729);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 730);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 731);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 732);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 733);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 734);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 735);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 736);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 737);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 738);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 739);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 740);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 741);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 742);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 743);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 744);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 745);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 746);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 747);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 748);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 749);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 750);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 751);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 752);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 753);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 754);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 755);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 756);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 757);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 758);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 759);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 760);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 761);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 762);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 763);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 764);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 765);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 766);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 767);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 768);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 769);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 770);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 771);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 772);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 773);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 774);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 775);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 776);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 777);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 778);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 779);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 780);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 781);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 782);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 783);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 784);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 785);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 786);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 787);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 788);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 789);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 790);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 791);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 792);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 793);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 794);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 795);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 796);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 797);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 798);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 799);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 800);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 801);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 802);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 803);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 804);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 805);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 806);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 807);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 808);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 809);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 810);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 811);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 812);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 813);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 814);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 815);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 816);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 817);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 818);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 819);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 820);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 821);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 822);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 823);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 824);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 825);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 826);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 827);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 828);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 829);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 830);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 831);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 832);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 833);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 834);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 835);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 836);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 837);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 838);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 839);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 840);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 841);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 842);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 843);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 844);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 845);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 846);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 847);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 848);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 849);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 850);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 851);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 852);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 853);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 854);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 855);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 856);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 857);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 858);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 859);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 860);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 861);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 862);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 863);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 864);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 865);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 866);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 867);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 868);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 869);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 870);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 871);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 872);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 873);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 874);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 875);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 876);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 877);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 878);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 879);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 880);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 881);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 882);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 883);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 884);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 885);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 886);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 887);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 888);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 889);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 890);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 891);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 892);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 893);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 894);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 895);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 896);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 897);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 898);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 899);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 900);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 901);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 902);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 903);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 904);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 905);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 906);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 907);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 908);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 909);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 910);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 911);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 912);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 913);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 914);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 915);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 916);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 917);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 918);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 919);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 920);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 921);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 922);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 923);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 924);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 925);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 926);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 927);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 928);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 929);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 930);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 931);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 932);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 933);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 934);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 935);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 936);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 937);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 938);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 939);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 940);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 941);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 942);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 943);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 944);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 945);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 946);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 947);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 948);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 949);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 950);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 951);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 952);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 953);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 954);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 955);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 956);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 957);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 958);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 959);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 960);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 961);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 962);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 963);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 964);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 965);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 966);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 967);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 968);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 969);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 970);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 971);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 972);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 973);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 974);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 975);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 976);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 977);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 978);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 979);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 980);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 981);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 982);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 983);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 984);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 985);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 986);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 987);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 988);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 989);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 990);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 991);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 992);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 993);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 994);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 995);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 996);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 997);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 998);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 999);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1000);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1001);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1002);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1003);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1004);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1005);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1006);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1007);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1008);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1009);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1010);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1011);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1012);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1013);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1014);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1015);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1016);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1017);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1018);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1019);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1020);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1021);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1022);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1023);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1024);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1025);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1026);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1027);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1028);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1029);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1030);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1031);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1032);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1033);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1034);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1035);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1036);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1037);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1038);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1039);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1040);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1041);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1042);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1043);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1044);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1045);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1046);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1047);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1048);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1049);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1050);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1051);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1052);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1053);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1054);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1055);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1056);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1057);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1058);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1059);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1060);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1061);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1062);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1063);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1064);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1065);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1066);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1067);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1068);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1069);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1070);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1071);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1072);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1073);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1074);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1075);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1076);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1077);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1078);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1079);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1080);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1081);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1082);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1083);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1084);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1085);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1086);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1087);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1088);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1089);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1090);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1091);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1092);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1093);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1094);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1095);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1096);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1097);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1098);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1099);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1100);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1101);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1102);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1103);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1104);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1105);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1106);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1107);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1108);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1109);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1110);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1111);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1112);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1113);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1114);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1115);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1116);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1117);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1118);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1119);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1120);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1121);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1122);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1123);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1124);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1125);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1126);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1127);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1128);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1129);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1130);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1131);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1132);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1133);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1134);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1135);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1136);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1137);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1138);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1139);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1140);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1141);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1142);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1143);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1144);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1145);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1146);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1147);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1148);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1149);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1150);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1151);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1152);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1153);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1154);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1155);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1156);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1157);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1158);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1159);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1160);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1161);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1162);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1163);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1164);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1165);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1166);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1167);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1168);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1169);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1170);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1171);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1172);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1173);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1174);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1175);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1176);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1177);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1178);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1179);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1180);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1181);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1182);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1183);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1184);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1185);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1186);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1187);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1188);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1189);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1190);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1191);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1192);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1193);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1194);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1195);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1196);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1197);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1198);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1199);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1200);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1201);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1202);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1203);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1204);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1205);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1206);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1207);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1208);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1209);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1210);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1211);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1212);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1213);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1214);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1215);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1216);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1217);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1218);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1219);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1220);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1221);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1222);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1223);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1224);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1225);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1226);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1227);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1228);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1229);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1230);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1231);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1232);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1233);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1234);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1235);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1236);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1237);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1238);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1239);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1240);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1241);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1242);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1243);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1244);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1245);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1246);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1247);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1248);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1249);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1250);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1251);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1252);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1253);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1254);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1255);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1256);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1257);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1258);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1259);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1260);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1261);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1262);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1263);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1264);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1265);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1266);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1267);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1268);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1269);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1270);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1271);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1272);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1273);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1274);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1275);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1276);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1277);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1278);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1279);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1280);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1281);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1282);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1283);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1284);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1285);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1286);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1287);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1288);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1289);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1290);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1291);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1292);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1293);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1294);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1295);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1296);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1297);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1298);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1299);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1300);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1301);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1302);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1303);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1304);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1305);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1306);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1307);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1308);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1309);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1310);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1311);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1312);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1313);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1314);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1315);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1316);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1317);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1318);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1319);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1320);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1321);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1322);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1323);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1324);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1325);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1326);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1327);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1328);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1329);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1330);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1331);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1332);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1333);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1334);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1335);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1336);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1337);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1338);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1339);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1340);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1341);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1342);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1343);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1344);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1345);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1346);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1347);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1348);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1349);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1350);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1351);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1352);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1353);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1354);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1355);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1356);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1357);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1358);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1359);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1360);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1361);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1362);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1363);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1364);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1365);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1366);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1367);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1368);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1369);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1370);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1371);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1372);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1373);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1374);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1375);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1376);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1377);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1378);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1379);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1380);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1381);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1382);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1383);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1384);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1385);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1386);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1387);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1388);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1389);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1390);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1391);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1392);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1393);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1394);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1395);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1396);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1397);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1398);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1399);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1400);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1401);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1402);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1403);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1404);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1405);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1406);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1407);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1408);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1409);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1410);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1411);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1412);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1413);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1414);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1415);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1416);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1417);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1418);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1419);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1420);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1421);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1422);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1423);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1424);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1425);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1426);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1427);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1428);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1429);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1430);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1431);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1432);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1433);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1434);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1435);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1436);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1437);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1438);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1439);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1440);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1441);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1442);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1443);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1444);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1445);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1446);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1447);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1448);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1449);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1450);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1451);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1452);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1453);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1454);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1455);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1456);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1457);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1458);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1459);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1460);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1461);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1462);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1463);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1464);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1465);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1466);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1467);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1468);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1469);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1470);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1471);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1472);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1473);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1474);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1475);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1476);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1477);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1478);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1479);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1480);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1481);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1482);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1483);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1484);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1485);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1486);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1487);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1488);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1489);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1490);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1491);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1492);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1493);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1494);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1495);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1496);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1497);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1498);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1499);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1500);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1501);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1502);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1503);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1504);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1505);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1506);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1507);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1508);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1509);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1510);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1511);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1512);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1513);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1514);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1515);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1516);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1517);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1518);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1519);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1520);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1521);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1522);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1523);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1524);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1525);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1526);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1527);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1528);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1529);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1530);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1531);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1532);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1533);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1534);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1535);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1536);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1537);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1538);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1539);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1540);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1541);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1542);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1543);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1544);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1545);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1546);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1547);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1548);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1549);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1550);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1551);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1552);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1553);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1554);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1555);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1556);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1557);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1558);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1559);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1560);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1561);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1562);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1563);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1564);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1565);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1566);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1567);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1568);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1569);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1570);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1571);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1572);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1573);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1574);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1575);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1576);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1577);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1578);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1579);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1580);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1581);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1582);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1583);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1584);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1585);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1586);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1587);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1588);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1589);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1590);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1591);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1592);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1593);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1594);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1595);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1596);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1597);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1598);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1599);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1600);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1601);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1602);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1603);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1604);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1605);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1606);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1607);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1608);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1609);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1610);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1611);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1612);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1613);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1614);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1615);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1616);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1617);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1618);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1619);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1620);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1621);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1622);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1623);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1624);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1625);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1626);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1627);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1628);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1629);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1630);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1631);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1632);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1633);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1634);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1635);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1636);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1637);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1638);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1639);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1640);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1641);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1642);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1643);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1644);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1645);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1646);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1647);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1648);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1649);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1650);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1651);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1652);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1653);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1654);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1655);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1656);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1657);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1658);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1659);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1660);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1661);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1662);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1663);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1664);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1665);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1666);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1667);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1668);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1669);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1670);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1671);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1672);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1673);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1674);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1675);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1676);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1677);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1678);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1679);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1680);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1681);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1682);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1683);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1684);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1685);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1686);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1687);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1688);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1689);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1690);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1691);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1692);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1693);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1694);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1695);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1696);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1697);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1698);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1699);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1700);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1701);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1702);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1703);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1704);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1705);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1706);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1707);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1708);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1709);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1710);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1711);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1712);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1713);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1714);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1715);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1716);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1717);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1718);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1719);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1720);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1721);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1722);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1723);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1724);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1725);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1726);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1727);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1728);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1729);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1730);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1731);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1732);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1733);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1734);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1735);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1736);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1737);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1738);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1739);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1740);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1741);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1742);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1743);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1744);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1745);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1746);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1747);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1748);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1749);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1750);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1751);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1752);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1753);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1754);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1755);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1756);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1757);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1758);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1759);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1760);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1761);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1762);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1763);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1764);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1765);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1766);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1767);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1768);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1769);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1770);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1771);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1772);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1773);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1774);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1775);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1776);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1777);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1778);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1779);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1780);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1781);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1782);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1783);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1784);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1785);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1786);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1787);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1788);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1789);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1790);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1791);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1792);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1793);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1794);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1795);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1796);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1797);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1798);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1799);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1800);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1801);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1802);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1803);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1804);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1805);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1806);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1807);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1808);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1809);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1810);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1811);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1812);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1813);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1814);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1815);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1816);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1817);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1818);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1819);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1820);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1821);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1822);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1823);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1824);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1825);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1826);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1827);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1828);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1829);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1830);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1831);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1832);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1833);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1834);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1835);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1836);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1837);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1838);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1839);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1840);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1841);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1842);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1843);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1844);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1845);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1846);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1847);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1848);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1849);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1850);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1851);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1852);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1853);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1854);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1855);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1856);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1857);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1858);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1859);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1860);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1861);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1862);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1863);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1864);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1865);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1866);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1867);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1868);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1869);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1870);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1871);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1872);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1873);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1874);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1875);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1876);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1877);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1878);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1879);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1880);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1881);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1882);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1883);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1884);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1885);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1886);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1887);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1888);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1889);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1890);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1891);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1892);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1893);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1894);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1895);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1896);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1897);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1898);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1899);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1900);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1901);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1902);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1903);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1904);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1905);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1906);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1907);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1908);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1909);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1910);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1911);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1912);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1913);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1914);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1915);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1916);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1917);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1918);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1919);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1920);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1921);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1922);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1923);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1924);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1925);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1926);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1927);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1928);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1929);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1930);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1931);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1932);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1933);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1934);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1935);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1936);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1937);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1938);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1939);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1940);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1941);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1942);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1943);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1944);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1945);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1946);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1947);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1948);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1949);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1950);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1951);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1952);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1953);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1954);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1955);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1956);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1957);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1958);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1959);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1960);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1961);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1962);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1963);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1964);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1965);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1966);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1967);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1968);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1969);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1970);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1971);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1972);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1973);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1974);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1975);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1976);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1977);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1978);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1979);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1980);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1981);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1982);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1983);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1984);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1985);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1986);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1987);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1988);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1989);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1990);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1991);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1992);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1993);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1994);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1995);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1996);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1997);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1998);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 1999);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2000);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2001);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2002);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2003);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2004);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2005);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2006);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2007);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2008);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2009);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2010);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2011);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2012);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2013);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2014);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2015);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2016);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2017);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2018);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2019);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2020);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2021);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2022);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2023);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2024);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2025);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2026);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2027);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2028);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2029);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2030);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2031);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2032);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2033);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2034);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2035);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2036);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2037);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2038);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2039);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2040);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2041);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2042);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2043);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2044);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2045);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2046);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2047);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2048);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2049);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2050);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2051);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2052);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2053);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2054);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2055);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2056);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2057);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2058);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2059);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2060);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2061);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2062);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2063);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2064);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2065);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2066);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2067);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2068);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2069);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2070);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2071);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2072);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2073);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2074);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2075);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2076);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2077);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2078);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2079);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2080);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2081);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2082);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2083);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2084);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2085);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2086);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2087);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2088);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2089);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2090);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2091);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2092);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2093);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2094);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2095);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2096);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2097);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2098);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2099);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2100);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2101);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2102);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2103);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2104);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2105);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2106);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2107);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2108);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2109);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2110);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2111);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2112);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2113);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2114);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2115);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2116);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2117);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2118);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2119);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2120);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2121);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2122);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2123);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2124);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2125);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2126);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2127);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2128);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2129);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2130);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2131);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2132);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2133);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2134);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2135);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2136);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2137);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2138);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2139);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2140);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2141);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2142);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2143);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2144);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2145);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2146);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2147);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2148);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2149);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2150);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2151);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2152);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2153);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2154);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2155);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2156);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2157);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2158);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2159);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2160);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2161);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2162);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2163);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2164);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2165);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2166);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2167);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2168);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2169);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2170);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2171);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2172);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2173);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2174);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2175);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2176);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2177);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2178);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2179);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2180);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2181);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2182);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2183);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2184);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2185);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2186);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2187);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2188);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2189);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2190);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2191);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2192);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2193);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2194);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2195);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2196);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2197);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2198);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2199);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2200);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2201);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2202);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2203);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2204);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2205);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2206);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2207);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2208);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2209);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2210);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2211);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2212);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2213);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2214);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2215);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2216);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2217);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2218);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2219);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2220);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2221);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2222);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2223);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2224);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2225);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2226);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2227);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2228);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2229);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2230);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2231);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2232);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2233);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2234);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2235);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2236);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2237);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2238);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2239);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2240);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2241);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2242);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2243);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2244);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2245);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2246);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2247);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2248);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2249);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2250);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2251);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2252);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2253);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2254);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2255);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2256);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2257);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2258);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2259);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2260);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2261);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2262);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2263);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2264);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2265);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2266);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2267);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2268);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2269);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2270);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2271);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2272);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2273);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2274);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2275);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2276);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2277);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2278);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2279);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2280);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2281);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2282);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2283);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2284);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2285);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2286);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2287);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2288);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2289);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2290);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2291);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2292);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2293);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2294);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2295);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2296);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2297);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2298);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2299);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2300);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2301);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2302);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2303);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2304);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2305);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2306);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2307);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2308);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2309);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2310);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2311);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2312);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2313);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2314);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2315);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2316);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2317);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2318);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2319);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2320);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2321);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2322);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2323);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2324);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2325);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2326);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2327);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2328);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2329);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2330);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2331);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2332);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2333);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2334);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2335);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2336);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2337);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2338);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2339);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2340);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2341);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2342);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2343);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2344);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2345);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2346);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2347);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2348);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2349);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2350);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2351);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2352);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2353);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2354);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2355);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2356);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2357);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2358);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2359);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2360);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2361);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2362);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2363);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2364);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2365);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2366);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2367);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2368);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2369);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2370);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2371);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2372);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2373);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2374);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2375);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2376);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2377);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2378);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2379);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2380);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2381);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2382);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2383);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2384);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2385);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2386);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2387);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2388);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2389);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2390);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2391);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2392);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2393);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2394);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2395);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2396);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2397);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2398);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2399);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2400);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2401);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2402);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2403);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2404);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2405);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2406);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2407);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2408);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2409);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2410);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2411);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2412);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2413);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2414);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2415);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2416);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2417);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2418);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2419);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2420);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2421);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2422);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2423);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2424);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2425);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2426);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2427);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2428);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2429);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2430);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2431);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2432);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2433);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2434);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2435);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2436);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2437);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2438);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2439);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2440);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2441);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2442);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2443);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2444);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2445);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2446);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2447);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2448);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2449);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2450);

            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 2451);
        }
    }
}
