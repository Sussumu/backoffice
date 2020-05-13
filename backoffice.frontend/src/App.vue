<template>
  <div id="app">
    <QueriesList></QueriesList>
  </div>
</template>

<script>
import QueriesList from '../src/pages/QueriesList';

export default {
  name: 'App',
  components: {
    QueriesList: QueriesList
  }
}
</script>

<style lang="scss">
@import "@/styles/nord.scss";

body {
  margin: 0;
  width: 100%;
  height: 100vh;
}

#app {  
  height: 100vh;
  background-color: $nord0;
  color: white;
}
</style>
