<template>
  <div id="queries-list-wrapper">
    <QueryTable :queries="queries"></QueryTable>
    <form id="new-query-form">
        <label>Name<input type="text" maxlength=100 v-model="query.name" /></label>
        <label>Description<input type="text" maxlength=200 v-model="query.description" /></label>
        <label>Query<textarea rows=4 columns=50 v-model="query.query" /></label>
        <label>Type
            <select v-model="query.queryType">
                <option value="1">Select</option>
                <option value="2">Insert</option>
                <option value="3">Update</option>
                <option value="4">Delete</option>
            </select>
        </label>
        <pre>TODO: Query params goes here!</pre>
        <button @click.prevent="submitQuery">New Query</button>
    </form>
  </div>
</template>

<script>
import QueryTable from '../components/QueryTable';
import { getAllQueries, newQuery } from '../clients/queriesClient';

export default {
    components: {
        QueryTable: QueryTable
    },
    data: function() {
        return {
            queries: [],
            query: {}
        }
    },
    methods: {
        submitQuery: async function () {
            let result = await newQuery(this.query);
            console.log(result);
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

#new-query-form > label > input,
#new-query-form > label > textarea,
#new-query-form > label > select,
#new-query-form > button {
    width: 100%;
}
</style>