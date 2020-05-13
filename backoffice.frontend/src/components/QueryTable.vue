<template>
    <table>
        <thead>
            <th>Id</th>
            <th>Name</th>
            <th>Query</th>
            <th>Description</th>
            <th>Type</th>
        </thead>
        <tbody>
            <tr 
                v-for="query in queries" 
                :key="query.Id" 
                @mouseover="onHover = true" 
                @mouseleave="onHover = false" 
                :class="{ activeRow: onHover }"
            >
                <td>{{query.Id}}</td>
                <td>{{query.Name}}</td>
                <td>{{query.Query}}</td>
                <td>{{query.Description}}</td>
                <td>{{query.Type}}</td>
            </tr>
        </tbody>
    </table>
</template>

<script>
export default {
    props: {
        queries: {
            required: true,
            type: Array,
            default: () => {}
        }
    },
    data() {
        return {
            onHover: false
        }
    }
}
</script>

<style lang="scss">
@import "@/styles/nord.scss";

table {
    border-collapse: collapse;
}

table > thead {
    border-bottom: 1px solid $nord3;
}

table > thead > th,
table > tbody > tr > td {
    padding: 10px 30px;
}

table > thead > th {
    border-bottom: 1px $nord3 solid;
}

table > tbody > tr.activeRow {
    background-color: $nord1;
}

</style>