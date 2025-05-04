function displayPagination() {
    let pag = document.getElementById('pagination');
    let html = '';

    if (currPage > 1)
        html += `<button onclick="changePage(${currPage - 1})" class="btn btn-sm btn-outline-secondary me-1">
                    <i class="bi bi-arrow-left"></i>
                 </button>`;

    for (let i = 1; i <= totalPage; i++)
        html += `<button onclick="changePage(${i})" class="btn btn-sm ${currPage === i ? 'btn-primary' : 'btn-outline-secondary'} me-1">${i}</button>`;

    if (currPage < totalPage)
        html += `<button onclick="changePage(${currPage + 1})" class="btn btn-sm btn-outline-secondary">
                    <i class="bi bi-arrow-right"></i>
                 </button>`;

    pag.innerHTML = html;
}

function changePage(page) {
    currPage = page;
    displayItem(currPage);
    displayPagination();
}