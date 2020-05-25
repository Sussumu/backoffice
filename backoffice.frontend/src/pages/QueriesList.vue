<template>
  <div>
    <QueryTable :queries="queries"></QueryTable>
  </div>
</template>

<script>
import QueryTable from '../components/QueryTable';
import { getAllQueries } from '../clients/queriesClient';

export default {
    components: {
        QueryTable: QueryTable
    },
    data: function() {
        return {
            queries: []
        }
    },
    created: async function() {
        this.queries = await getAllQueries();
    }
}
</script>