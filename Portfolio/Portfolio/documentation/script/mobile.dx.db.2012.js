$(function () {
    // JQuery drop down header
    $('p.hs-toggler a:first-child').addClass('btn');
    // Expandable text
    $('a[href*="HSToggleSection"]').addClass('btn');
    // In this Topic links
    $('div.hs-inthistopic-container a').addClass('btn btn-mini');
    // Language filtered code box
    $('span.CopyCode').addClass('btn btn-mini');
    // Remove slimbox click handler from dynamic image widget thumbnails
    $('a.hs-thumbnail').unbind('click');
    // Show all / hide all
    $('div#HSShowAll a, div#HSHideAll a').addClass('btn');
});
$(function () {
    $('td.LinkCell>a').addClass('btn');
    $('td.MembersLinkCell a').addClass('btn');
});
$(function () {
    $('div.communityratingcontainer').css('display', 'none');
    $('div#communityfooter').css('display', 'none');
});
$(function () {
    // drop down section
    $('div.SectionHeading').addClass('btn');
});
$(function () {
    $('table.RelationshipColumnListTable th a').addClass('btn btn-mini');
    $('div#overviewSectionContent a').addClass('btn btn-mini');

    var columnsTable = $('div#columnsSectionContent table.ColumnListTable');
    if (columnsTable.length) {
        var pivotDiv = pivotTable(columnsTable);
        pivotDiv.appendTo('div#columnsSectionContent');

        var primaryKeyRow = columnsTable.find('td:first-child img').first().closest('tr');
        var primaryKeyColumnName = primaryKeyRow.children('td.LinkCell').text();

        pivotDiv.children('span').each(function (index, element) {
            if ($(element).text() == primaryKeyColumnName) {
                var img = primaryKeyRow.find('td:first-child img').first();
                img.insertBefore($(element));
            }
        });
    }
});
