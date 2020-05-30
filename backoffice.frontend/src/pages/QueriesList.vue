<template>
  <div id="queries-list-wrapper">
    <QueryTable :queries="queries"></QueryTable>
    <form id="new-query-form">
        <label>Name<input type="text" /></label>
        <label>Description<input type="text" /></label>
        <label>Query<textarea rows=4 columns=50 /></label>
        <pre>TODO: Query params goes here!</pre>
        <button>New Query</button>
    </form>
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

<style lang="scss">
#queries-list-wrapper {
    display: flex;
}

#new-query-form {
    display: flex;
    flex-direction: column;
    margin-left: 40px;
}

#new-query-form > label {
    margin-top: 20px;
}

#new-query-form > label > input {
    width: 10%;
}
</style>