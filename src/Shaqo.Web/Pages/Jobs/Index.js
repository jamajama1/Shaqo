
$(function () {
    var l = abp.localization.getResource('Shaqo');
    
    var dataTable = $('#JobsTable').DataTable(
        abp.libs.datatables.normalizeConfiguration({
            serverSide: true,
            paging: true,
            order: [[1, "asc"]],
            searching: true,
            scrollX: true,
            ajax: abp.libs.datatables.createAjax(shaqo.jobs.job.getList),
            columnDefs: [
                {
                    title: l('Actions'),
                    rowAction: {
                        items:
                            [
                                {
                                    text: l('Edit'),
                                    visible: abp.auth.isGranted('Shaqo.Jobs.Edit'),
                                    action: function (data) {
                                        editModal.open({ id: data.record.id });
                                    }
                                },
                                {
                                    text: l('Delete'),
                                    visible: abp.auth.isGranted('Shaqo.Jobs.Delete'),
                                    confirmMessage: function (data) {
                                        return l(
                                            'JobDeletionConfirmationMessage',
                                            data.record.name
                                        );
                                    },
                                    action: function (data) {
                                        shaqo.jobs.job
                                            .delete(data.record.id)
                                            .then(function () {
                                                abp.notify.info(
                                                    l('SuccessfullyDeleted')
                                                );
                                                dataTable.ajax.reload();
                                            });
                                    }
                                }
                            ]
                    }
                },
                {
                    title: l('Title'),
                    data: "title"
                },
                {
                    title: l('Description'),
                    data: "description"
                },
                {
                    title: l('Location'),
                    data: "location"
                },
                {
                    title: l('Salary'),
                    data: "salary",
                    render: DataTable.render.number(null, null, 2, '$')
                },
                {
                    title: l('CreationTime'), data: "creationTime",
                    render: function (data) {
                        return luxon
                            .DateTime
                            .fromISO(data, {
                                locale: abp.localization.currentCulture.name
                            }).toLocaleString(luxon.DateTime.DATETIME_SHORT);
                    }
                }
            ]
        })
    );


    var createModal = new abp.ModalManager(abp.appPath + 'Jobs/CreateModal');
    var editModal = new abp.ModalManager(abp.appPath + 'Jobs/EditModal');

    createModal.onResult(function () {
        dataTable.ajax.reload();
    });

    editModal.onResult(function () {
        dataTable.ajax.reload();
    });

    $('#NewJobButton').click(function (e) {
        e.preventDefault();
        createModal.open();
    });
});


