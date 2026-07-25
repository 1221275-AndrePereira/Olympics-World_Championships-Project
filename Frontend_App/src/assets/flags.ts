// Maps country names (as they appear in the workbook) to ISO2 codes used by flagcdn.com.
// A couple of historical/non-ISO entries (Soviet Union, Yugoslavia) fall back to a local
// /assets/flags/ path instead - see FLAG_FALLBACK_BASE in results-browser.component.ts.
export const FLAG_MAP: Record<string, string> = {
  Afghanistan: 'af', Albania: 'al', Algeria: 'dz', 'American Samoa': 'as', Andorra: 'ad',
  Angola: 'ao', 'Antigua and Barbuda': 'ag', Argentina: 'ar', Armenia: 'am', Aruba: 'aw',
  Australia: 'au', Austria: 'at', Azerbaijan: 'az', Bahamas: 'bs', Bahrain: 'bh',
  Bangladesh: 'bd', Barbados: 'bb', Belarus: 'by', Belgium: 'be', Belize: 'bz',
  Benin: 'bj', Bermuda: 'bm', Bhutan: 'bt', Bolivia: 'bo', Bosnia: 'ba', Botswana: 'bw',
  Brazil: 'br', 'British Virgin Islands': 'vg', Brunei: 'bn', Bulgaria: 'bg',
  'Burkina Faso': 'bf', Burundi: 'bi', Cambodia: 'kh', Cameroon: 'cm', Canada: 'ca',
  'Cape Verde': 'cv', 'Cayman Islands': 'ky', 'Central African Republic': 'cf', Chad: 'td',
  Chile: 'cl', China: 'cn', Colombia: 'co', Comoros: 'km', Congo: 'cg', 'DR Congo': 'cd',
  'Cook Islands': 'ck', 'Costa Rica': 'cr', Croatia: 'hr', Cuba: 'cu', Cyprus: 'cy',
  'Czech Republic': 'cz', Denmark: 'dk', Djibouti: 'dj', Dominica: 'dm',
  'Dominican Republic': 'do', Ecuador: 'ec', Egypt: 'eg', 'El Salvador': 'sv',
  'Equatorial Guinea': 'gq', Eritrea: 'er', Estonia: 'ee', Eswatini: 'sz', Ethiopia: 'et',
  Fiji: 'fj', Finland: 'fi', France: 'fr', Gabon: 'ga', Gambia: 'gm', Georgia: 'ge',
  Germany: 'de', Ghana: 'gh', Greece: 'gr', Grenada: 'gd', Guam: 'gu', Guatemala: 'gt',
  Guinea: 'gn', 'Guinea-Bissau': 'gw', Guyana: 'gy', Haiti: 'ht', Honduras: 'hn',
  'Hong Kong': 'hk', Hungary: 'hu', Iceland: 'is', India: 'in', Indonesia: 'id',
  Iran: 'ir', Iraq: 'iq', Ireland: 'ie', Israel: 'il', Italy: 'it', 'Ivory Coast': 'ci',
  Jamaica: 'jm', Japan: 'jp', Jordan: 'jo', Kazakhstan: 'kz', Kenya: 'ke', Kiribati: 'ki',
  Kosovo: 'xk', Kuwait: 'kw', Kyrgyzstan: 'kg', Laos: 'la', Latvia: 'lv', Lebanon: 'lb',
  Lesotho: 'ls', Liberia: 'lr', Libya: 'ly', Liechtenstein: 'li', Lithuania: 'lt',
  Luxembourg: 'lu', Madagascar: 'mg', Malawi: 'mw', Malaysia: 'my', Maldives: 'mv',
  Mali: 'ml', Malta: 'mt', 'Marshall Islands': 'mh', Mauritania: 'mr', Mauritius: 'mu',
  Mexico: 'mx', Micronesia: 'fm', Moldova: 'md', Monaco: 'mc', Mongolia: 'mn',
  Montenegro: 'me', Morocco: 'ma', Mozambique: 'mz', Myanmar: 'mm', Namibia: 'na',
  Nauru: 'nr', Nepal: 'np', Netherlands: 'nl', 'New Zealand': 'nz', Nicaragua: 'ni',
  Niger: 'ne', Nigeria: 'ng', 'North Korea': 'kp', Macedonia: 'mk', Norway: 'no',
  Oman: 'om', Pakistan: 'pk', Palau: 'pw', Palestine: 'ps', Panama: 'pa',
  'Papua New Guinea': 'pg', Paraguay: 'py', Peru: 'pe', Philippines: 'ph', Poland: 'pl',
  Portugal: 'pt', 'Puerto Rico': 'pr', Qatar: 'qa', Romania: 'ro', Russia: 'ru',
  Rwanda: 'rw', 'Saint Kitts and Nevis': 'kn', 'Saint Lucia': 'lc',
  'Saint Vincent and Grenadines': 'vc', Samoa: 'ws', 'San Marino': 'sm',
  'São Tomé': 'st', 'Saudi Arabia': 'sa', Senegal: 'sn', Serbia: 'rs', Seychelles: 'sc',
  'Sierra Leone': 'sl', Singapore: 'sg', Slovakia: 'sk', Slovenia: 'si',
  'Solomon Islands': 'sb', Somalia: 'so', 'South Africa': 'za', 'South Korea': 'kr',
  'South Sudan': 'ss', Spain: 'es', 'Sri Lanka': 'lk', Sudan: 'sd', Suriname: 'sr',
  Sweden: 'se', Switzerland: 'ch', Syria: 'sy', Taiwan: 'tw', Tajikistan: 'tj',
  Tanzania: 'tz', Thailand: 'th', 'East Timor': 'tl', Togo: 'tg', Tonga: 'to',
  'Trinidad and Tobago': 'tt', Tunisia: 'tn', Turkey: 'tr', Turkmenistan: 'tm',
  Tuvalu: 'tv', Uganda: 'ug', Ukraine: 'ua', 'United Arab Emirates': 'ae',
  'Great Britain': 'gb', 'United States': 'us', 'Virgin Islands': 'vi', Uruguay: 'uy',
  Uzbekistan: 'uz', Vanuatu: 'vu', Venezuela: 've', Vietnam: 'vn', Yemen: 'ye',
  Zambia: 'zm', Zimbabwe: 'zw',
  'Soviet Union': 'soviet_union', Yugoslavia: 'yugoslavia'
};
 
export const FLAGCDN_BASE = 'https://flagcdn.com/w40';
// Non-ISO historical entries (length > 2 in FLAG_MAP) fall back to a local path -
// drop matching images into src/assets/flags/ if you want those to render too.
export const FLAG_FALLBACK_BASE = '/assets/flags';
 
export function flagUrlFor(country: string): string | null {
  const code = FLAG_MAP[country];
  if (!code) return null;
  return code.length === 2 ? `${FLAGCDN_BASE}/${code}.png` : `${FLAG_FALLBACK_BASE}/${code}.png`;
}