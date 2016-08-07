function replaceTag(str) {
	var regexForReplace = /<a(.*?)>(.*?)<\/a>/gi;
	
	return str.replace(regexForReplace, '[URL$1]$2[/URL]');
}

console.log(replaceTag('<ul><li><a href=http://softuni.bg>SoftUni</a></li></ul>'));