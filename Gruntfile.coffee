"use strict"

module.exports = ( grunt ) ->

  require( "matchdep" ).filterDev( "grunt-*" ).forEach grunt.loadNpmTasks

  grunt.initConfig
    # html
    jade:
      options:
        pretty: no
        data:
            version: "0.4.0"
      page:
        files:
          "index.html": "src/jade/index.jade"
    # CSS
    stylus:
      options:
        compress: no
        use: [
          require "kouto-swiss"
        ]
      styles:
        files:
          "assets/unclean.css": "src/stylus/styles.styl"
    uncss:
      options:
        stylesheets: [ "assets/unclean.css" ]
      styles:
        files:
          "assets/styles.css": [ "index.html" ]
    csso:
      options:
        report: "gzip"
      styles:
        files:
          "assets/styles.min.css": "assets/styles.css"
    # Watch
    watch:
      jade:
        files: "src/jade/index.jade"
        tasks: [ "html" ]
        options:
          livereload: yes
      styles:
        files: "src/stylus/styles.styl"
        tasks: [ "css" ]
        options:
          livereload: yes

  grunt.registerTask "html", [ "jade" ]

  grunt.registerTask "css", [
    "stylus"
    "uncss"
    "csso"
  ]

  grunt.registerTask "default", [
    "html"
    "css"
  ]

  grunt.registerTask "work", [
    "jade"
    "css"
    "watch"
  ]
