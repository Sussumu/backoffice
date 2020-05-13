<template>
  <div>
    <QueryTable :queries="queries"></QueryTable>
  </div>
</template>

<script>
import QueryTable from '../components/QueryTable';

const queries = [
    {
        Id: 1,
        Name: 'Test',
        Query: 'select top 1 * from query',
        Description: 'Selects the first result from query table',
        Type: 1
    }
]

export default {
    components: {
        QueryTable: QueryTable
    },
    data: function() {
        return {
            queries: queries
        }
    }
}
</script>