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
                :key="query.id" 
                @mouseover="onMouseOver(query.id)" 
                @mouseleave="onMouseLeave()" 
                :class="{ activeRow: query.id == selectedRow }"
            >
                <td>{{query.id}}</td>
                <td>{{query.name}}</td>
                <td>{{query.query}}</td>
                <td>{{query.description}}</td>
                <td>{{query.type}}</td>
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
            selectedRow: -1
        }
    },
    methods: {
        onMouseOver: function (id) {
            this.selectedRow = id;
        },
        onMouseLeave: function () {
            this.selectedRow = -1;
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